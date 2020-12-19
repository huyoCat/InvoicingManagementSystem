using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InvoicingManagementSystem
{
    public partial class CA_checkOut : Form
    {
        public CA_checkOut()
        {
            InitializeComponent();
        }

        //传值
        //String goods_salespersonID="";
        //public static String DGVgoods = CA_checkOut.dataGridView_GoodsList.Name.ToString();


        //委托
        //private Action reLoad = null;

        //单例实现
        //private static AD_FormBooksList formBooksList = null;
        private int count;

        private void CA_checkOut_Load(object sender, EventArgs e)
        {
            InitSelect();//加载筛选列表
            SqlDataRefresh();//加载所有商品
        }

        private void InitSelect()
        {
            string sql = "select id,name from saleKeywordList where id<3";
            DataTable dataTableSelectList = SqlHelper.GetDataTable(sql);
            DataRow dataRowSelectList = dataTableSelectList.NewRow();
            dataRowSelectList["id"] = 0;
            dataRowSelectList["name"] = "请选择";
            dataTableSelectList.Rows.InsertAt(dataRowSelectList, 0);

            comboBoxKeyword.DataSource = dataTableSelectList;
            comboBoxKeyword.DisplayMember = "name";
            comboBoxKeyword.ValueMember = "id";
        }

        private void InitAllGoods()
        {
            string sql = "select goods_id,goods_name,goods_type,goods_units," +
                "goods_retailPrice from GoodsList where goods_inventory>0";
            DataTable dataTableGoodsList = SqlHelper.GetDataTable(sql);
            dataGridView_GoodsList.DataSource = dataTableGoodsList;
        }

        /// <summary>
        /// 两个列表的刷新
        /// </summary>
        public void SqlDataRefresh()
        {
            //刷新购物清单
            string sql = "select goods_id,goods_name,goods_units," +
                "goods_retailPrice,goods_inventory from GoodsList where IsSelect=1 and IsDeleted=0";
            DataTable dataTableBookList = SqlHelper.GetDataTable(sql);
            dataGridView_SalesList.DataSource = dataTableBookList;

            //刷新商品列表
            string sql1 = "select goods_id,goods_name,goods_type,goods_units," +
                "goods_retailPrice,goods_inventory from GoodsList where goods_inventory>0 and IsDeleted=0";
            DataTable dataTableGoodsList = SqlHelper.GetDataTable(sql1);
            dataGridView_GoodsList.DataSource = dataTableGoodsList;
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            //获取查询条件
            int SearchSID = (int)comboBoxKeyword.SelectedValue;
            string keyWord = textBox_search.Text.Trim();

            string sql = "select goods_id,goods_name,goods_type,goods_units," +
                "goods_retailPrice,goods_inventory from GoodsList where goods_inventory>0 and IsDeleted=0";
            //sql += " where 1=1";
            if (SearchSID > 0)
            {
                if (SearchSID == 1)
                {
                    if (string.IsNullOrEmpty(keyWord))
                    {
                        MessageBox.Show("请输入关键字！");
                    }
                    else
                    {
                        sql += "and goods_id like @goods_id";
                    }

                }
                if (SearchSID == 2)
                {
                    if (string.IsNullOrEmpty(keyWord))
                    {
                        MessageBox.Show("请输入关键字！");
                    }
                    else
                    {
                        sql += "and goods_name like @goods_name";
                    }
                }
            }

            SqlParameter[] parameters =
            {
                new SqlParameter("@goods_id","%"+keyWord+"%"),
                new SqlParameter("@goods_name","%"+keyWord+"%"),
            };
            DataTable dataTableGoodsList = SqlHelper.GetDataTable(sql, parameters);
            dataGridView_GoodsList.DataSource = dataTableGoodsList;
        }


        /// <summary>
        /// 当点击添加按钮，将所选的商品信息在商品列表删除，添加至购物清单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btADD_Click(object sender, EventArgs e)
        {
            //选择
            //获取所选数据
            List<String> listId = new List<String>();
            for (int i = 0; i < dataGridView_GoodsList.Rows.Count; i++)
            {
                DataGridViewCheckBoxCell cell = dataGridView_GoodsList.Rows[i].Cells["ColChecked"]
                    as DataGridViewCheckBoxCell;
                bool check = Convert.ToBoolean(cell.Value);
                if (check)
                {
                    DataRow dataRow = (dataGridView_GoodsList.Rows[i].DataBoundItem as DataRowView).Row;
                    String goods_id = dataRow["goods_id"].ToString();
                    listId.Add(goods_id);
                }
            }

            //判断所选数据个数，需>0
            if (listId.Count == 0)
            {
                MessageBox.Show("请选择要添加至购物清单的商品！", "添加购物清单提示",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (MessageBox.Show("您确定要将所选商品添加至购物清单吗？", "添加购物清单提示",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //启动事务
                    using (SqlConnection connection = new SqlConnection(SqlHelper.connectionString))
                    {
                        connection.Open();
                        SqlTransaction transaction = connection.BeginTransaction();
                        SqlCommand command = new SqlCommand();
                        command.Connection = connection;
                        command.Transaction = transaction;
                        try
                        {
                            foreach (String goods_id in listId)
                            {
                                command.CommandText = "update GoodsList set IsSelect=1 where goods_id=@goods_id";
                                SqlParameter parameter = new SqlParameter("@goods_id", goods_id);
                                command.Parameters.Clear();
                                command.Parameters.Add(parameter);
                                count += command.ExecuteNonQuery();
                            }
                            transaction.Commit();
                        }
                        catch (SqlException ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show("购物清单添加出现异常！", "添加购物清单提示",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    if (count == listId.Count)
                    {
                        //lbCost.Text=
                        MessageBox.Show("购物清单添加成功！", "添加购物清单提示",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                    //刷新
                    SqlDataRefresh();
                    double sum = 0;
                    if (dataGridView_SalesList.Rows.Count > 0)
                    {
                        for (int i = 0; i < dataGridView_SalesList.Rows.Count; i++)
                        {
                            int number = 0;
                            double retailPrice = 0;

                            DataRow dataRow = (dataGridView_SalesList.Rows[i].DataBoundItem as DataRowView).Row;
                            DataGridViewCell dataGridViewCell = dataGridView_SalesList.Rows[i].Cells["goods_number"];
                            int.TryParse(dataGridViewCell.EditedFormattedValue.ToString(), out number);
                            DataGridViewCell dataGridViewCell1 = dataGridView_SalesList.Rows[i].Cells["retailPrice"];
                            double.TryParse(dataGridViewCell1.EditedFormattedValue.ToString(), out retailPrice);
                            sum = number * retailPrice + sum;
                            
                        }
                    }
                    lbCost.Text = sum.ToString() + "元";
                }

            }

        }

        /// <summary>
        /// 从购物清单移除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btDelete_Click(object sender, EventArgs e)
        {
            //选择
            //获取所选数据
            List<String> listId = new List<String>();
            for (int i = 0; i < dataGridView_SalesList.Rows.Count; i++)
            {
                DataGridViewCheckBoxCell cell = dataGridView_SalesList.Rows[i].Cells["ColOrderCheck"]
                    as DataGridViewCheckBoxCell;
                bool check = Convert.ToBoolean(cell.Value);
                if (check)
                {
                    DataRow dataRow = (dataGridView_SalesList.Rows[i].DataBoundItem as DataRowView).Row;
                    String goods_id = dataRow["goods_id"].ToString();
                    listId.Add(goods_id);
                }
            }

            //判断所选数据个数，需>0
            if (listId.Count == 0)
            {
                MessageBox.Show("请选择要从购物清单删除的商品！", "移除购物清单提示",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (MessageBox.Show("您确定要将所选商品移除购物清单吗？", "移除购物清单提示",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //启动事务
                    using (SqlConnection connection = new SqlConnection(SqlHelper.connectionString))
                    {
                        connection.Open();
                        SqlTransaction transaction = connection.BeginTransaction();
                        SqlCommand command = new SqlCommand();
                        command.Connection = connection;
                        command.Transaction = transaction;
                        try
                        {
                            foreach (String goods_id in listId)
                            {
                                command.CommandText = "update GoodsList set IsSelect=0 where goods_id=@goods_id";
                                SqlParameter parameter = new SqlParameter("@goods_id", goods_id);
                                command.Parameters.Clear();
                                command.Parameters.Add(parameter);
                                count += command.ExecuteNonQuery();
                            }
                            transaction.Commit();
                        }
                        catch (SqlException ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show("移除商品出现异常！", "移除购物清单提示",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    if (count == listId.Count)
                    {
                        MessageBox.Show("移除商品成功！", "移除购物清单提示",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                    //刷新
                    SqlDataRefresh();
                    double sum = 0;
                    if (dataGridView_SalesList.Rows.Count > 0)
                    {
                        for (int i = 0; i < dataGridView_SalesList.Rows.Count; i++)
                        {
                            int number = 0;
                            double retailPrice = 0;

                            DataRow dataRow = (dataGridView_SalesList.Rows[i].DataBoundItem as DataRowView).Row;
                            DataGridViewCell dataGridViewCell = dataGridView_SalesList.Rows[i].Cells["goods_number"];
                            int.TryParse(dataGridViewCell.EditedFormattedValue.ToString(), out number);
                            DataGridViewCell dataGridViewCell1 = dataGridView_SalesList.Rows[i].Cells["retailPrice"];
                            double.TryParse(dataGridViewCell1.EditedFormattedValue.ToString(), out retailPrice);
                            sum = number * retailPrice + sum;

                        }
                    }
                    lbCost.Text = sum.ToString() + "元";
                }

            }
        }

        /// <summary>
        /// 点击提交按钮，将出售的商品信息写入售出商品表，商品列表更新库存（IsSelect置0）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btSubmit_Click(object sender, EventArgs e)
        {
            //获取数据
            List<String> listId = new List<String>();
            for (int i = 0; i < dataGridView_SalesList.Rows.Count; i++)
            {
                DataRow dataRow = (dataGridView_SalesList.Rows[i].DataBoundItem as DataRowView).Row;
                String goods_id = dataRow["goods_id"].ToString();
                listId.Add(goods_id);

            }
            //判断清单有没有数据
            if (listId.Count == 0)
            {
                MessageBox.Show("请从商品列表选择商品！", "购物提示",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (MessageBox.Show("您确定要购买商品吗？", "购物提示",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //启动事务
                    using (SqlConnection connection = new SqlConnection(SqlHelper.connectionString))
                    {
                        connection.Open();
                        SqlTransaction transaction = connection.BeginTransaction();
                        SqlCommand command = new SqlCommand();
                        command.Connection = connection;
                        command.Transaction = transaction;
                        try
                        {
                            //LoginForm iden = new LoginForm();
                            String goods_name = "";
                            String goods_type = "";
                            int goods_number = 1;//购买数量默认为1
                            String goods_units = "";
                            String goods_retailPrice = "";
                            int goods_inventory = 0;
                            String goods_soldDate = "";
                            String goods_salespersonID = LoginForm.Employee_id;
                            int flag = 0;//获取输入的购买数量用到的参数
                            foreach (String goods_id in listId)
                            {
                                //获取数据
                                string sqlGetDate = "select goods_id,goods_name,goods_type,goods_units,goods_retailPrice,goods_inventory from GoodsList " +
                                    "where goods_id=@goods_id";
                                SqlParameter paraID = new SqlParameter("@goods_id", goods_id);
                                SqlDataReader dataReader = SqlHelper.ExecuteReader(sqlGetDate, paraID);
                                //读取数据
                                //DataRow dataRow = (dataGridView_SalesList.Rows[flag].DataBoundItem as DataRowView).Row;
                                DataGridViewCell dataGridViewCell = dataGridView_SalesList.Rows[flag].Cells["goods_number"];
                                if (flag < dataGridView_SalesList.Rows.Count)
                                {
                                    flag++;
                                }
                                int.TryParse(dataGridViewCell.EditedFormattedValue.ToString(), out goods_number);
                                //if(!("".Equals(dataGridViewCell.Value.ToString()))&& dataGridViewCell.Value.ToString() != null)
                                //{
                                //goods_number = (int)dataGridViewCell.Value.ToString();
                                //}

                                if (dataReader.Read())//没有这一步会说DataReader没有启动
                                {
                                    goods_name = dataReader["goods_name"].ToString();
                                    goods_type = dataReader["goods_type"].ToString();
                                    goods_units = dataReader["goods_units"].ToString();
                                    goods_retailPrice = dataReader["goods_retailPrice"].ToString();
                                    goods_soldDate = DateTime.Now.ToString("yyyy.MM.dd");
                                    goods_inventory= (int)dataReader["goods_inventory"];
                                    //int.TryParse(this.Tag.ToString(), out goods_inventory);
                                }
                                dataReader.Close();

                                if ("".Equals(goods_id) || "".Equals(goods_type) || "".Equals(goods_units)
                                    || "".Equals(goods_retailPrice) || "".Equals(goods_soldDate) || "".Equals(goods_salespersonID))
                                {
                                    MessageBox.Show("数据出现异常！", "购物提示",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else if ((goods_inventory - goods_number) < 0)
                                {
                                    MessageBox.Show($"商品:{goods_name}库存不足！", "购物提示",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                else
                                {
                                    //执行添加
                                    string sqlEdit = "insert into SalesList " +
                                        "(goods_id,goods_name,goods_type,goods_number,goods_units,goods_retailPrice,goods_soldDate,goods_salespersonID) " +
                                        "values (@goods_id,@goods_name,@goods_type,@goods_number,@goods_units,@goods_retailPrice,@goods_soldDate,@goods_salespersonID)";
                                    SqlParameter[] parametersEdit =
                                    {
                                    new SqlParameter("@goods_id",goods_id),
                                    new SqlParameter("@goods_name",goods_name),
                                    new SqlParameter("@goods_type",goods_type),
                                    new SqlParameter("@goods_number",goods_number),
                                    new SqlParameter("@goods_units",goods_units),
                                    new SqlParameter("@goods_retailPrice",goods_retailPrice),
                                    new SqlParameter("@goods_soldDate",goods_soldDate),
                                    new SqlParameter("@goods_salespersonID",goods_salespersonID)
                                    };

                                    //执行并返回
                                    int count = SqlHelper.ExecuteNonQuery(sqlEdit, parametersEdit);
                                    if (count > 0)
                                    {
                                        goods_inventory = goods_inventory-goods_number;
                                        //在商品列表更新库存数量
                                        String sql = "update GoodsList set IsSelect=0 where goods_id=@goods_id " +
                                            "update GoodsList set goods_inventory = @goods_inventory where goods_id =@goods_id";
                                        SqlParameter[] parameter = {//这里是拿来参数化的，否则数据库不认识变量
                                            new SqlParameter("@goods_id",goods_id),
                                            new SqlParameter("@goods_inventory",goods_inventory)
                                        };
                                        SqlHelper.ExecuteNonQuery(sql, parameter);

                                    }
                                    else
                                    {
                                        MessageBox.Show("数据库修改失败！", "购物提示",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }
                                }
                            }
                            transaction.Commit();
                        }
                        catch (SqlException ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show("购买商品出现异常！", "购物提示",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    if (count == listId.Count)
                    {
                        MessageBox.Show("购买商品成功！", "购物提示",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    //刷新
                    SqlDataRefresh();
                    lbCost.Text = "0";
                }
            }
        }

        //当单元格的值改变时触发
        private void dataGridView_SalesList_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            double sum = 0;
            if (dataGridView_SalesList.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView_SalesList.Rows.Count; i++)
                {
                    int number = 0;
                    double retailPrice = 0;

                    DataRow dataRow = (dataGridView_SalesList.Rows[i].DataBoundItem as DataRowView).Row;
                    DataGridViewCell dataGridViewCell = dataGridView_SalesList.Rows[i].Cells["goods_number"];
                    int.TryParse(dataGridViewCell.EditedFormattedValue.ToString(), out number);
                    DataGridViewCell dataGridViewCell1 = dataGridView_SalesList.Rows[i].Cells["retailPrice"];
                    double.TryParse(dataGridViewCell1.EditedFormattedValue.ToString(), out retailPrice);
                    sum = number * retailPrice + sum;

                }
            }
            lbCost.Text = sum.ToString() + "元";
        }
    }
}

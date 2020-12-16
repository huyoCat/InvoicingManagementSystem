using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InvoicingManagementSystem
{
    public partial class WH_SelectInventory : Form
    {
        private int count;

        public WH_SelectInventory()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 当点击搜索按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btSearch_Click(object sender, EventArgs e)
        {
            //获取查询条件
            int SearchSID = (int)comboBoxKeyword.SelectedValue;
            string keyWord = textBox_search.Text.Trim();

            string sql = "select goods_id,goods_name,goods_type,goods_units," +
                "goods_purchasingCost,goods_productionDate,goods_expirationDate,goods_supplier," +
                "goods_inventory from GoodsList where IsDeleted=0 ";
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

                if (SearchSID == 3)
                {
                    //按照库存排序
                    sql += "order by goods_inventory";
                }
                if (SearchSID == 4)
                {
                    //按照日期顺序排序
                    sql += "order by goods_expirationDate";
                }
            }

            SqlParameter[] parameters =
            {
                new SqlParameter("@goods_id","%"+keyWord+"%"),
                new SqlParameter("@goods_name","%"+keyWord+"%"),
            };
            DataTable dataTableGoodsList = SqlHelper.GetDataTable(sql, parameters);
            dataGridView_SelectInventory.DataSource = dataTableGoodsList;
        }

        private void WH_SelectInventory_Load(object sender, EventArgs e)
        {
            InitSelect();//加载筛选列表
            SqlDataRefresh();//加载所有商品
        }

        private void InitSelect()
        {
            string sql = "select id,name from saleKeywordList where id<5";
            DataTable dataTableSelectList = SqlHelper.GetDataTable(sql);
            DataRow dataRowSelectList = dataTableSelectList.NewRow();
            dataRowSelectList["id"] = 0;
            dataRowSelectList["name"] = "请选择";
            dataTableSelectList.Rows.InsertAt(dataRowSelectList, 0);

            comboBoxKeyword.DataSource = dataTableSelectList;
            comboBoxKeyword.DisplayMember = "name";
            comboBoxKeyword.ValueMember = "id";
        }

        /// <summary>
        /// 两个列表的刷新
        /// </summary>
        public void SqlDataRefresh()
        {
            //刷新商品列表
            string sql1 = "select goods_id,goods_name,goods_type,goods_units," +
                "goods_purchasingCost,goods_productionDate,goods_expirationDate,goods_supplier," +
                "goods_inventory from GoodsList where IsDeleted=0";
            DataTable dataTableGoodsList = SqlHelper.GetDataTable(sql1);
            dataGridView_SelectInventory.DataSource = dataTableGoodsList;


            //刷新订购清单
            string sql = "select goods_id, goods_name, goods_type, goods_units," +
                "goods_purchasingCost,goods_supplier,goods_inventory from GoodsList where IsSelect=1 and IsDeleted=0";
            DataTable dataTableBookList = SqlHelper.GetDataTable(sql);
            dataGridView_order.DataSource = dataTableBookList;
        }

        private void btADD_Click(object sender, EventArgs e)
        {
            //选择
            //获取所选数据
            List<String> listId = new List<String>();
            for (int i = 0; i < dataGridView_SelectInventory.Rows.Count; i++)
            {
                DataGridViewCheckBoxCell cell = dataGridView_SelectInventory.Rows[i].Cells["ColCheck"]
                    as DataGridViewCheckBoxCell;
                bool check = Convert.ToBoolean(cell.Value);
                if (check)
                {
                    DataRow dataRow = (dataGridView_SelectInventory.Rows[i].DataBoundItem as DataRowView).Row;
                    String goods_id = dataRow["goods_id"].ToString();
                    listId.Add(goods_id);
                }
            }
            //判断所选数据个数，需>0
            if (listId.Count == 0)
            {
                MessageBox.Show("请选择要订购的商品！", "订购提示",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (MessageBox.Show("您确定要订购商品吗？", "订购提示",
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
                            MessageBox.Show("商品订购添加出现异常！", "订购提示",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    if (count == listId.Count)
                    {
                        MessageBox.Show("订购商品添加成功！", "订购提示",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                    //刷新
                    SqlDataRefresh();

                }
            }
        }
        /// <summary>
        /// 提交订购单，将订购信息写入数据库orderList
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_submit_Click(object sender, EventArgs e)
        {
            //获取数据
            List<String> listId = new List<String>();
            for (int i = 0; i < dataGridView_order.Rows.Count; i++)
            {
                DataRow dataRow = (dataGridView_order.Rows[i].DataBoundItem as DataRowView).Row;
                String goods_id = dataRow["goods_id"].ToString();
                listId.Add(goods_id);

            }

            //判断清单有没有数据
            if (listId.Count == 0)
            {
                MessageBox.Show("请从商品列表选择商品！", "订购提示",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                return;
            }

            else
            {
                if (MessageBox.Show("您确定要订购商品吗？", "订购提示",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(SqlHelper.connectionString))
                    {
                        connection.Open();
                        SqlTransaction transaction = connection.BeginTransaction();
                        SqlCommand command = new SqlCommand();
                        command.Connection = connection;
                        command.Transaction = transaction;

                        try
                        {
                            String goods_name = "";
                            String goods_type = "";
                            String goods_units = "";
                            String goods_purchasingCost = "";
                            String goods_supplier = "";
                            int goods_purNumber = 1;//购买数量默认为1
                            String goods_SubmitDate="";
                            String order_inventoryID = LoginForm.Employee_id;

                            int flag = 0;//获取输入的购买数量用到的参数
                            foreach (String goods_id in listId)
                            {
                                //获取数据
                                string sqlGetDate = "select goods_id,goods_name,goods_type,goods_units," +
                                    "goods_purchasingCost,goods_supplier from GoodsList " +
                                    "where goods_id=@goods_id";
                                SqlParameter paraID = new SqlParameter("@goods_id", goods_id);
                                SqlDataReader dataReader = SqlHelper.ExecuteReader(sqlGetDate, paraID);

                                //读取数据
                                DataGridViewCell dataGridViewCell = dataGridView_order.Rows[flag].Cells["goods_purNumber"];
                                if (flag < dataGridView_order.Rows.Count)
                                {
                                    flag++;
                                }
                                int.TryParse(dataGridViewCell.EditedFormattedValue.ToString(), out goods_purNumber);

                                if (dataReader.Read())//没有这一步会说DataReader没有启动
                                {
                                    //goods_id = dataReader["goods_id"].ToString();
                                    goods_name = dataReader["goods_name"].ToString();
                                    goods_type = dataReader["goods_type"].ToString();
                                    goods_units = dataReader["goods_units"].ToString();
                                    goods_purchasingCost = dataReader["goods_purchasingCost"].ToString();
                                    goods_supplier = dataReader["goods_supplier"].ToString();
                                    goods_SubmitDate = DateTime.Now.ToString("yyyy.MM.dd");
                                    //goods_inventory = (int)dataReader["goods_inventory"];
                                    //int.TryParse(this.Tag.ToString(), out goods_inventory);
                                }
                                dataReader.Close();

                                if ("".Equals(goods_id) || "".Equals(goods_type) || "".Equals(goods_units)
                                    || "".Equals(goods_purchasingCost) || "".Equals(goods_supplier) ||
                                    "".Equals(goods_SubmitDate )|| "".Equals(order_inventoryID))
                                {
                                    MessageBox.Show("数据出现异常！", "购物提示",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }

                                else
                                {
                                    //执行添加
                                    string sqlEdit = "insert into orderList " +
                                        "(goods_id,goods_name,goods_type,goods_units,goods_purchasingCost,goods_supplier,goods_purNumber," +
                                        "goods_SubmitDate,order_inventoryID) " +
                                        "values (@goods_id,@goods_name,@goods_type,@goods_units,@goods_purchasingCost,@goods_supplier," +
                                        "@goods_purNumber,@goods_SubmitDate,@order_inventoryID)";
                                    SqlParameter[] parametersEdit =
                                    {
                                        new SqlParameter("@goods_id",goods_id),
                                        new SqlParameter("@goods_name",goods_name),
                                        new SqlParameter("@goods_type",goods_type),
                                        new SqlParameter("@goods_units",goods_units),
                                        new SqlParameter("@goods_purchasingCost",goods_purchasingCost),
                                        new SqlParameter("@goods_supplier",goods_supplier),
                                        new SqlParameter("@goods_purNumber",goods_purNumber),
                                        new SqlParameter("@goods_SubmitDate",goods_SubmitDate),
                                        new SqlParameter("@order_inventoryID",order_inventoryID)
                                    };

                                    //执行并返回
                                    int count = SqlHelper.ExecuteNonQuery(sqlEdit, parametersEdit);
                                    if (count > 0)
                                    {
                                        //修改为不可见
                                        string sqlBookList = "update GoodsList set IsSelect=0 where goods_id=@goods_id";
                                        SqlParameter[] parameters2 =
                                        {
                                            new SqlParameter("@goods_id",goods_id)
                                        };
                                        int count1 = SqlHelper.ExecuteNonQuery(sqlBookList, parameters2);

                                        if (count1 <= 0)
                                        {
                                            MessageBox.Show("数据库信息修改失败！","订购信息", 
                                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }

                                    else
                                    {
                                        MessageBox.Show("修改选择状态失败！", "系统错误信息",
                                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }
                                }
                            }
                            transaction.Commit();
                        }

                        catch(SqlException ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show("订购商品出现异常！", "订购提示",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    if (count == listId.Count)
                    {
                        MessageBox.Show("订购商品成功！", "订购提示",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    //刷新
                    SqlDataRefresh();
                }
            }
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            //选择
            //获取所选数据
            List<String> listId = new List<String>();
            for (int i = 0; i < dataGridView_order.Rows.Count; i++)
            {
                DataGridViewCheckBoxCell cell = dataGridView_order.Rows[i].Cells["CHECK"]
                    as DataGridViewCheckBoxCell;
                bool check = Convert.ToBoolean(cell.Value);
                if (check)
                {
                    DataRow dataRow = (dataGridView_order.Rows[i].DataBoundItem as DataRowView).Row;
                    String goods_id = dataRow["goods_id"].ToString();
                    listId.Add(goods_id);
                }
            }

            //判断所选数据个数，需>0
            if (listId.Count == 0)
            {
                MessageBox.Show("请选择要从订购清单删除的商品！", "移除订购清单提示",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (MessageBox.Show("您确定要将所选商品移除订购清单吗？", "移除订购清单提示",
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
                            MessageBox.Show("移除商品出现异常！", "移除订购清单提示",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    if (count == listId.Count)
                    {
                        MessageBox.Show("移除商品成功！", "移除订购清单提示",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    //刷新
                    SqlDataRefresh();
                }
            }
        }
        /// <summary>
        /// 商品下架（邻近保质期等原因）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_removeGood_Click(object sender, EventArgs e)
        {
            //选择
            //获取所选数据
            List<String> listId = new List<String>();
            for (int i = 0; i < dataGridView_SelectInventory.Rows.Count; i++)
            {
                DataGridViewCheckBoxCell cell = dataGridView_SelectInventory.Rows[i].Cells["ColCheck"]
                    as DataGridViewCheckBoxCell;
                bool check = Convert.ToBoolean(cell.Value);
                if (check)
                {
                    DataRow dataRow = (dataGridView_SelectInventory.Rows[i].DataBoundItem as DataRowView).Row;
                    String goods_id = dataRow["goods_id"].ToString();
                    listId.Add(goods_id);
                }
            }
            //判断所选数据个数，需>0
            if (listId.Count == 0)
            {
                MessageBox.Show("请选择要下架的商品！", "删除商品提示",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (MessageBox.Show("您确定要下架所选商品吗？", "删除商品提示",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //启动事务，删除
                    using (SqlConnection connection = new SqlConnection(SqlHelper.connectionString))
                    {
                        connection.Open();
                        SqlTransaction transaction = connection.BeginTransaction();
                        SqlCommand command = new SqlCommand();
                        command.Connection = connection;
                        command.Transaction = transaction;
                        try
                        {
                            //跳出填写信息的弹窗
                            string goods_note = Interaction.InputBox("请填写下架理由：", "商品下架", "在这里输入", -1, -1);
                            foreach (string goods_id in listId)
                            {
                                string sql = "update GoodsList set IsDeleted=1 where goods_id=@goods_id " +
                                    "update GoodsList set goods_note=@goods_note where goods_id=@goods_id";
                                SqlParameter[] parameters2 =
                                    {
                                            new SqlParameter("@goods_id",goods_id),
                                            new SqlParameter("@goods_note",goods_note)
                                        };
                                int count1 = SqlHelper.ExecuteNonQuery(sql, parameters2);
                            }
                            transaction.Commit();

                        }
                        catch (SqlException ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show("下架商品出现异常！", "删除商品提示",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    if (count == listId.Count)
                    {
                        MessageBox.Show("商品下架成功！", "删除商品提示",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

            SqlDataRefresh();
        }
    }
}

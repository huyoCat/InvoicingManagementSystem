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

        //委托
        private Action reLoad = null;

        //单例实现
        //private static AD_FormBooksList formBooksList = null;
        private int count;

        private void CA_checkOut_Load(object sender, EventArgs e)
        {
            InitSelect();//加载筛选列表
            InitAllGoods();//加载所有书
        }

        private void InitSelect()
        {
            string sql = "select id,name from saleKeywordList";
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
                "goods_retailPrice from GoodsList where IsDeleted=0";
            DataTable dataTableGoodsList = SqlHelper.GetDataTable(sql);
            dataGridView_GoodsList.DataSource = dataTableGoodsList;
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            //获取查询条件
            int SearchSID = (int)comboBoxKeyword.SelectedValue;
            string keyWord = textBox_search.Text.Trim();

            string sql = "select goods_id,goods_name,goods_type,goods_units," +
                "goods_retailPrice from GoodsList where IsDeleted=0";
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
                new SqlParameter("@goods_type","%"+keyWord+"%"),
                new SqlParameter("@goods_units","%"+keyWord+"%"),
                new SqlParameter("@goods_retailPrice","%"+keyWord+"%"),
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
                            foreach (String goods_id in listId)
                            {
                                //将数据添加置购物清单
                                

                                //将添加后的数据置0
                                command.CommandText = "update GoodsList set IsDeleted=1 where goods_id=@goods_id";
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
                            MessageBox.Show("加入购物清单出现异常！", "添加购物清单提示",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    if (count == listId.Count)
                    {
                        MessageBox.Show("添加成功！", "添加购物清单提示",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    //刷新数据列表
                    string sql1 = "select goods_id,goods_name,goods_type,goods_units," +
                        "goods_retailPrice from GoodsList where IsDeleted=0";
                    DataTable dataTableBookList = SqlHelper.GetDataTable(sql1);
                    dataGridView_GoodsList.DataSource = dataTableBookList;
                }
            }

        }
    }
}

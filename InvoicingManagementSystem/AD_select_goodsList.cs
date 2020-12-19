using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InvoicingManagementSystem
{
    public partial class AD_select_goodsList : Form
    {
        public AD_select_goodsList()
        {
            InitializeComponent();
        }

        private void AD_select_goodsList_Load(object sender, EventArgs e)
        {
            InitSelect();//加载筛选列表
            SqlDataRefresh();//加载所有商品
        }

        private void InitSelect()
        {
            string sql = "select id,name from saleKeywordList where id<5 or id=7 or id=9 or id=14";
            DataTable dataTableSelectList = SqlHelper.GetDataTable(sql);
            DataRow dataRowSelectList = dataTableSelectList.NewRow();
            dataRowSelectList["id"] = 0;
            dataRowSelectList["name"] = "请选择";
            dataTableSelectList.Rows.InsertAt(dataRowSelectList, 0);

            comboBoxKeyword.DataSource = dataTableSelectList;
            comboBoxKeyword.DisplayMember = "name";
            comboBoxKeyword.ValueMember = "id";
        }

        public void SqlDataRefresh()
        {
            //刷新商品列表
            string sql1 = "select * from GoodsList";
            DataTable dataTableGoodsList = SqlHelper.GetDataTable(sql1);
            dataGridView_select_goodsList.DataSource = dataTableGoodsList;
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            //获取查询条件
            int SearchSID = (int)comboBoxKeyword.SelectedValue;
            string keyWord = textBox_search.Text.Trim();

            string sql = "select * from GoodsList where 1=1 ";
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
                if (SearchSID == 7)
                {
                    if (string.IsNullOrEmpty(keyWord))
                    {
                        MessageBox.Show("请输入关键字！");
                    }
                    else
                    {
                        sql += "and goods_type like @goods_type";
                    }
                }
                if (SearchSID == 9)
                {
                    if (string.IsNullOrEmpty(keyWord))
                    {
                        MessageBox.Show("请输入关键字！");
                    }
                    else
                    {
                        sql += "and goods_supplier like @goods_supplier";
                    }
                }
                if (SearchSID == 14)
                {
                    if (string.IsNullOrEmpty(keyWord))
                    {
                        MessageBox.Show("查看在售商品输入0，下架商品输入1");
                    }
                    else
                    {
                        sql += "and IsDeleted="+keyWord;
                    }
                }
            }

            SqlParameter[] parameters =
            {
                new SqlParameter("@goods_id","%"+keyWord+"%"),
                new SqlParameter("@goods_name","%"+keyWord+"%"),
                new SqlParameter("@goods_type","%"+keyWord+"%"),
                new SqlParameter("@goods_supplier","%"+keyWord+"%"),
            };
            DataTable dataTableGoodsList = SqlHelper.GetDataTable(sql, parameters);
            dataGridView_select_goodsList.DataSource = dataTableGoodsList;
        }

        //委托
        private Action reLoad = null;
        private int count;

        /// <summary>
        /// 修改或删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView_select_goodsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //获取行数据
            DataRow dataRow = (dataGridView_select_goodsList.Rows[e.RowIndex].DataBoundItem as DataRowView).Row;
            if (e.RowIndex != -1)
            {
                //获取当前单元格
                DataGridViewCell dataGridViewCell = dataGridView_select_goodsList.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (dataGridViewCell is DataGridViewLinkCell &&
                    dataGridViewCell.FormattedValue.ToString() == "删除")
                {
                    //删除操作
                    if (MessageBox.Show("您确定要删除该商品信息吗？", "删除商品提示",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        string Employee_id = dataRow["goods_id"].ToString();
                        string sqlDel0 = "delete from GoodsList where goods_id=@goods_id";
                        SqlParameter parameter = new SqlParameter("@goods_id", Employee_id);
                        int count = SqlHelper.ExecuteNonQuery(sqlDel0, parameter);
                        if (count > 0)
                        {
                            MessageBox.Show("该商品信息删除成功！", "删除商品提示",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //手动刷新信息
                            DataTable dataTableEmployeeList = (DataTable)dataGridView_select_goodsList.DataSource;
                            //DGVBookList.DataSource = null;
                            dataTableEmployeeList.Rows.Remove(dataRow);
                            dataGridView_select_goodsList.DataSource = dataTableEmployeeList;
                        }
                        else
                        {
                            MessageBox.Show("该商品信息删除失败！", "删除商品提示",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
                //修改操作
                else if (dataGridViewCell is DataGridViewLinkCell &&
                dataGridViewCell.FormattedValue.ToString() == "修改")
                {
                    //修改操作
                    reLoad = SqlDataRefresh;
                    string goods_id = dataRow["goods_id"].ToString();
                    string goods_type = dataRow["goods_type"].ToString();
                    string goods_supplier = dataRow["goods_supplier"].ToString();
                    AD_EditGoodInfo editGoodInfo = new AD_EditGoodInfo();
                    //传值
                    //editBookInfo.Tag = Bid;
                    editGoodInfo.Tag = new TagObject()
                    {
                        goods_id = goods_id,
                        goods_type = goods_type,
                        goods_supplier = goods_supplier,
                        ReLoad = reLoad
                    };
                    editGoodInfo.MdiParent = this.MdiParent;//指定修改页面的父容器
                    editGoodInfo.Show();
                }
            }
        }

        /// <summary>
        /// 批量删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btDelete_Click(object sender, EventArgs e)
        {
            //选择
            //获取所选数据
            List<String> listId = new List<String>();
            for (int i = 0; i < dataGridView_select_goodsList.Rows.Count; i++)
            {
                DataGridViewCheckBoxCell cell = dataGridView_select_goodsList.Rows[i].Cells["check"]
                    as DataGridViewCheckBoxCell;
                bool check = Convert.ToBoolean(cell.Value);
                if (check)
                {
                    DataRow dataRow = (dataGridView_select_goodsList.Rows[i].DataBoundItem as DataRowView).Row;
                    String goods_id = dataRow["goods_id"].ToString();
                    listId.Add(goods_id);
                }
            }
            //判断所选数据个数，需>0
            if (listId.Count == 0)
            {
                MessageBox.Show("请选择要删除的商品！", "删除商品提示",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (MessageBox.Show("您确定要删除所选商品吗？", "删除商品提示",
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
                            foreach (string goods_id in listId)
                            {
                                string sql = "delete from GoodsList where goods_id=@goods_id";
                                SqlParameter[] parameters2 =
                                    {
                                            new SqlParameter("@goods_id",goods_id)
                                        };
                                int count1 = SqlHelper.ExecuteNonQuery(sql, parameters2);
                            }
                            transaction.Commit();

                        }
                        catch (SqlException ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show("删除商品出现异常！", "删除商品提示",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    if (count == listId.Count)
                    {
                        MessageBox.Show("商品删除成功！", "删除商品提示",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

            SqlDataRefresh();
        }
    }
}

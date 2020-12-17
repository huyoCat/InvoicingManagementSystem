using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InvoicingManagementSystem
{
    public partial class AD_addGoodType : Form
    {
        private int count;

        public AD_addGoodType()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 点击添加按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btADD_Click(object sender, EventArgs e)
        {
            //获取数据
            int Sort_id = 0;
            int.TryParse(tb_typeID.Text, out Sort_id);
            string Sort_name = tb_typeName.Text;

            //判断是否为空
            if ("".Equals(Sort_name) || Sort_name == null ||
                "".Equals(Sort_id) || Sort_id == 0)
            {
                MessageBox.Show("请将信息填写完整且确保填写正确！");
                return;
            }
            else
            {
                //查询数据库中是否存在
                string sqlSelect = "select * from GoodsSortList where " +
                    "Sort_id=@Sort_id or Sort_name=@Sort_name";
                SqlParameter[] parametersEdit =
                {
                    new SqlParameter("@Sort_id",Sort_id),
                    new SqlParameter("@Sort_name",Sort_name)
                };
                //执行并返回
                object o = SqlHelper.ExecuteScalar(sqlSelect, parametersEdit);
                if (o == null)
                {
                    //无查询结果，插入数据
                    string sqlInsert = "insert into GoodsSortList values(@Sort_id,@Sort_name)";
                    SqlParameter[] parametersInsert =
                    {
                        new SqlParameter("@Sort_id",Sort_id),
                        new SqlParameter("@Sort_name",Sort_name)
                    };
                    int count = SqlHelper.ExecuteNonQuery(sqlInsert, parametersInsert);
                    if (count > 0)
                    {
                        tb_typeID.Text = "";
                        tb_typeName.Text = "";
                        MessageBox.Show("添加成功！");
                    }
                    else
                    {
                        MessageBox.Show("添加失败！");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("商品编号或名称已存在！");
                    return;
                }
                SqlDataRefresh();
            }
        }

        /// <summary>
        /// 页面初始化先显示列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AD_addGoodType_Load(object sender, EventArgs e)
        {
            InitSelect();//加载筛选列表
            SqlDataRefresh();//加载所有商品种类
        }

        private void InitSelect()
        {
            string sql = "select id,name from saleKeywordList where id>5 and id<8";
            DataTable dataTableSelectList = SqlHelper.GetDataTable(sql);
            DataRow dataRowSelectList = dataTableSelectList.NewRow();
            dataRowSelectList["id"] = 0;
            dataRowSelectList["name"] = "请选择";
            dataTableSelectList.Rows.InsertAt(dataRowSelectList, 0);

            comboBoxKeyword.DataSource = dataTableSelectList;
            comboBoxKeyword.DisplayMember = "name";
            comboBoxKeyword.ValueMember = "id";
        }

        private void SqlDataRefresh()
        {
            string sql = "select * from GoodsSortList";
            DataTable dataTableGoodsList = SqlHelper.GetDataTable(sql);
            dataGridView_GoodsTypeList.DataSource = dataTableGoodsList;
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            //获取查询条件
            int SearchSID = (int)comboBoxKeyword.SelectedValue;
            string keyWord = textBox_search.Text.Trim();

            string sql = "select * from GoodsSortList where 1=1";
            if (SearchSID > 0)
            {
                if (SearchSID == 6)
                {
                    if (string.IsNullOrEmpty(keyWord))
                    {
                        MessageBox.Show("请输入关键字！");
                    }
                    else
                    {
                        sql += "and Sort_id like @Sort_id";
                    }

                }
                if (SearchSID == 7)
                {
                    if (string.IsNullOrEmpty(keyWord))
                    {
                        MessageBox.Show("请输入关键字！");
                    }
                    else
                    {
                        sql += "and Sort_name like @Sort_name";
                    }
                }
            }
            SqlParameter[] parameters =
            {
                new SqlParameter("@Sort_id","%"+keyWord+"%"),
                new SqlParameter("@Sort_name","%"+keyWord+"%"),
            };
            DataTable dataTableGoodsList = SqlHelper.GetDataTable(sql, parameters);
            dataGridView_GoodsTypeList.DataSource = dataTableGoodsList;
        }

        /// <summary>
        /// 删除商品种类信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btDelete_Click(object sender, EventArgs e)
        {
            //获取所选数据
            List<int> listId = new List<int>();
            for (int i = 0; i < dataGridView_GoodsTypeList.Rows.Count; i++)
            {
                DataGridViewCheckBoxCell cell = dataGridView_GoodsTypeList.Rows[i].Cells["ColChecked"]
                as DataGridViewCheckBoxCell;
                bool check = Convert.ToBoolean(cell.Value);
                if (check)
                {
                    DataRow dataRow = (dataGridView_GoodsTypeList.Rows[i].DataBoundItem as DataRowView).Row;
                    int Sort_id=0;
                    int.TryParse(dataRow["Sort_id"].ToString(), out Sort_id);
                    if (Sort_id != 0)
                    {
                        listId.Add(Sort_id);
                    }
                }

                //判断所选数据个数，需>0
                if (listId.Count == 0)
                {
                    MessageBox.Show("请选择需要删除的种类！");
                    return;
                }
                else
                {
                    //执行删除
                    if (MessageBox.Show("您确定要将所选商品种类删除吗？", "删除商品种类提示",
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
                                foreach (int Sort_id in listId)
                                {
                                    command.CommandText = "delete from GoodsSortList where Sort_id=@Sort_id";
                                    SqlParameter parameter = new SqlParameter("@Sort_id", Sort_id);
                                    command.Parameters.Clear();
                                    command.Parameters.Add(parameter);
                                    count += command.ExecuteNonQuery();
                                }
                                transaction.Commit();
                            }
                            catch (SqlException ex)
                            {
                                transaction.Rollback();
                                MessageBox.Show("移除商品种类出现异常！", "删除商品种类提示",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        if (count == listId.Count)
                        {
                            MessageBox.Show("移除商品种类成功！", "删除商品种类提示",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        //刷新
                        SqlDataRefresh();

                    }
                }
            }
        }
    }
}

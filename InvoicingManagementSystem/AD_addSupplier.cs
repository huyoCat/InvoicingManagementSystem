using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InvoicingManagementSystem
{
    public partial class AD_addSupplier : Form
    {
        private int count;

        public AD_addSupplier()
        {
            InitializeComponent();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            //获取查询条件
            int SearchSID = (int)comboBoxKeyword.SelectedValue;
            string keyWord = textBox_search.Text.Trim();

            string sql = "select * from SupplierList where 1=1 ";
            if (SearchSID > 0)
            {
                if (SearchSID == 8)
                {
                    if (string.IsNullOrEmpty(keyWord))
                    {
                        MessageBox.Show("请输入关键字！");
                    }
                    else
                    {
                        sql += "and id like @id";
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
                        sql += "and name like @name";
                    }
                }
            }
            SqlParameter[] parameters =
            {
                new SqlParameter("@id","%"+keyWord+"%"),
                new SqlParameter("@name","%"+keyWord+"%"),
            };
            DataTable dataTableGoodsList = SqlHelper.GetDataTable(sql, parameters);
            dataGridView_SupplierList.DataSource = dataTableGoodsList;
        }

        private void AD_addSupplier_Load(object sender, EventArgs e)
        {
            InitSelect();//加载筛选列表
            SqlDataRefresh();//加载所有商品种类
        }

        private void InitSelect()
        {
            string sql = "select id,name from saleKeywordList where id>7 and id<10";
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
            string sql = "select * from SupplierList";
            DataTable dataTableGoodsList = SqlHelper.GetDataTable(sql);
            dataGridView_SupplierList.DataSource = dataTableGoodsList;
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btADD_Click(object sender, EventArgs e)
        {
            //获取数据
            int id = 0;
            int.TryParse(tb_id.Text, out id);
            string name = tb_name.Text;
            string Contact = tb_Contact.Text;

            //判断是否为空
            if ("".Equals(name) || name == null ||
                "".Equals(id) || id == 0 ||
                "".Equals(Contact) || Contact == null)
            {
                MessageBox.Show("请将信息填写完整且确保填写正确！");
                return;
            }
            else
            {
                //查询数据库中是否存在
                string sqlSelect = "select * from SupplierList where " +
                    "id=@id or name=@name";
                SqlParameter[] parametersEdit =
                {
                    new SqlParameter("@id",id),
                    new SqlParameter("@name",name)
                };
                //执行并返回
                object o = SqlHelper.ExecuteScalar(sqlSelect, parametersEdit);
                if (o == null)
                {
                    //无查询结果，插入数据
                    string sqlInsert = "insert into SupplierList values(@id,@name,@Contact)";
                    SqlParameter[] parametersInsert =
                    {
                        new SqlParameter("@id",id),
                        new SqlParameter("@name",name),
                        new SqlParameter("@Contact",Contact)
                    };
                    int count = SqlHelper.ExecuteNonQuery(sqlInsert, parametersInsert);
                    if (count > 0)
                    {
                        tb_id.Text = "";
                        tb_name.Text = "";
                        tb_Contact.Text = "";
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
                    MessageBox.Show("供应商编号或名称已存在！");
                    return;
                }
                SqlDataRefresh();
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            //获取所选数据
            List<int> listId = new List<int>();
            for (int i = 0; i < dataGridView_SupplierList.Rows.Count; i++)
            {
                DataGridViewCheckBoxCell cell = dataGridView_SupplierList.Rows[i].Cells["Checked"]
                as DataGridViewCheckBoxCell;
                bool check = Convert.ToBoolean(cell.Value);
                if (check)
                {
                    DataRow dataRow = (dataGridView_SupplierList.Rows[i].DataBoundItem as DataRowView).Row;
                    int id = 0;
                    int.TryParse(dataRow["id"].ToString(), out id);
                    if (id != 0)
                    {
                        listId.Add(id);
                    }
                }
            }

            //判断所选数据个数，需>0
            if (listId.Count == 0)
            {
                MessageBox.Show("请选择需要删除的供应商！");
                return;
            }
            else
            {
                //执行删除
                if (MessageBox.Show("您确定要将所选供应商删除吗？", "删除供应商提示",
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
                            foreach (int id in listId)
                            {
                                command.CommandText = "delete from SupplierList where id=@id";
                                SqlParameter parameter = new SqlParameter("@id", id);
                                command.Parameters.Clear();
                                command.Parameters.Add(parameter);
                                count += command.ExecuteNonQuery();
                            }
                            transaction.Commit();
                        }
                        catch (SqlException ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show("移除供应商出现异常！", "删除供应商提示",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    if (count == listId.Count)
                    {
                        MessageBox.Show("移除供应商成功！", "删除供应商提示",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    //刷新
                    SqlDataRefresh();

                }
            }
        }

    }
}

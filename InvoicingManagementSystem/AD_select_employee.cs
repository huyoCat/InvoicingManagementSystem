using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoicingManagementSystem
{
    public partial class AD_select_employee : Form
    {
        public AD_select_employee()
        {
            InitializeComponent();
        }

        private void AD_select_employee_Load(object sender, EventArgs e)
        {
            InitSelect();//加载筛选列表
            SqlDataRefresh();//加载所有商品种类
        }

        private void InitSelect()
        {
            string sql = "select id,name from saleKeywordList where id>9 and id<13";
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
            string sql = "select * from EmployeeList";
            DataTable dataTableGoodsList = SqlHelper.GetDataTable(sql);
            dataGridView_EmployeeList.DataSource = dataTableGoodsList;
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            //获取查询条件
            int SearchSID = (int)comboBoxKeyword.SelectedValue;
            string keyWord = textBox_search.Text.Trim();

            string sql = "select * from EmployeeList where 1=1 ";
            if (SearchSID > 0)
            {
                if (SearchSID == 10)
                {
                    if (string.IsNullOrEmpty(keyWord))
                    {
                        MessageBox.Show("请输入关键字！");
                    }
                    else
                    {
                        sql += "and Employee_id like @Employee_id";
                    }

                }
                if (SearchSID == 11)
                {
                    if (string.IsNullOrEmpty(keyWord))
                    {
                        MessageBox.Show("请输入关键字！");
                    }
                    else
                    {
                        sql += "and Employee_name like @Employee_name";
                    }
                }
                if (SearchSID == 12)
                {
                    if (string.IsNullOrEmpty(keyWord))
                    {
                        MessageBox.Show("请输入关键字！");
                    }
                    else
                    {
                        sql += "and Employee_identify like @Employee_identify";
                    }
                }
            }
            SqlParameter[] parameters =
            {
                new SqlParameter("@Employee_id","%"+keyWord+"%"),
                new SqlParameter("@Employee_name","%"+keyWord+"%"),
                new SqlParameter("@Employee_identify","%"+keyWord+"%")
            };
            DataTable dataTableGoodsList = SqlHelper.GetDataTable(sql, parameters);
            dataGridView_EmployeeList.DataSource = dataTableGoodsList;
        }

        /// <summary>
        /// 删除员工
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView_EmployeeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //获取行数据
            DataRow dataRow = (dataGridView_EmployeeList.Rows[e.RowIndex].DataBoundItem as DataRowView).Row;
            if (e.RowIndex != -1)
            {
                //获取当前单元格
                DataGridViewCell dataGridViewCell = dataGridView_EmployeeList.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (dataGridViewCell is DataGridViewLinkCell &&
                    dataGridViewCell.FormattedValue.ToString() == "删除")
                {
                    //删除操作
                    if (MessageBox.Show("您确定要删除该雇员信息吗？", "删除雇员提示",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        string Employee_id = dataRow["Employee_id"].ToString();
                        //假删除,程序不显示，但数据库数据仍存在
                        string sqlDel0 = "delete from EmployeeList where Employee_id=@Employee_id";
                        SqlParameter parameter = new SqlParameter("@Employee_id", Employee_id);
                        int count = SqlHelper.ExecuteNonQuery(sqlDel0, parameter);
                        if (count > 0)
                        {
                            MessageBox.Show("该雇员信息删除成功！", "删除雇员提示",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //手动刷新信息
                            DataTable dataTableEmployeeList = (DataTable)dataGridView_EmployeeList.DataSource;
                            //DGVBookList.DataSource = null;
                            dataTableEmployeeList.Rows.Remove(dataRow);
                            dataGridView_EmployeeList.DataSource = dataTableEmployeeList;
                        }
                        else
                        {
                            MessageBox.Show("该雇员信息删除失败！", "删除雇员提示",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
            }
        }
    }
}

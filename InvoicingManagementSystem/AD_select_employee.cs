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
    }
}

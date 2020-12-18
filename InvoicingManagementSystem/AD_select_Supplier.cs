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
    public partial class AD_select_Supplier : Form
    {
        public AD_select_Supplier()
        {
            InitializeComponent();
        }

        private void AD_select_Supplier_Load(object sender, EventArgs e)
        {
            InitSelect();//加载筛选列表
            SqlDataRefresh();//加载所有商品种类
        }

        private void InitSelect()
        {
            string sql = "select id,name from saleKeywordList where id>7 and id<10 or id=13";
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
                if (SearchSID == 13)
                {
                    if (string.IsNullOrEmpty(keyWord))
                    {
                        MessageBox.Show("请输入关键字！");
                    }
                    else
                    {
                        sql += "and Contact like @Contact";
                    }
                }
            }
            SqlParameter[] parameters =
            {
                new SqlParameter("@id","%"+keyWord+"%"),
                new SqlParameter("@name","%"+keyWord+"%"),
                new SqlParameter("@Contact","%"+keyWord+"%"),
            };
            DataTable dataTableGoodsList = SqlHelper.GetDataTable(sql, parameters);
            dataGridView_SupplierList.DataSource = dataTableGoodsList;

        }
    }
}

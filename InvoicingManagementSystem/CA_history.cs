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
    public partial class CA_history : Form
    {
        public CA_history()
        {
            InitializeComponent();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            //获取查询条件
            int SearchSID = (int)comboBoxKeyword.SelectedValue;
            string keyWord = textBox_search.Text.Trim();

            string sql = "select goods_id,goods_name,goods_type,goods_units," +
                "goods_retailPrice,goods_soldDate,goods_salespersonID from SalesList where 1=1";
            //where 1=1的必要性是防止多重条件时where关键字重复
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
            DataTable dataTableSalesList = SqlHelper.GetDataTable(sql, parameters);
            dataGridView_SalesList.DataSource = dataTableSalesList;
        }

        private void CA_history_Load(object sender, EventArgs e)
        {
            InitSelect();//加载筛选列表
            InitAllSalesList();//加载所有商品
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

        private void InitAllSalesList()
        {
            string sql = "select goods_id,goods_name,goods_type,goods_units," +
                "goods_retailPrice,goods_soldDate,goods_salespersonID from SalesList";
            DataTable dataTableSalesList = SqlHelper.GetDataTable(sql);
            dataGridView_SalesList.DataSource = dataTableSalesList;
        }
    }
}

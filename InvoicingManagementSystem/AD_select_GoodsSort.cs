using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InvoicingManagementSystem
{
    public partial class AD_select_GoodsSort : Form
    {
        public AD_select_GoodsSort()
        {
            InitializeComponent();
        }

        private void AD_select_GoodsSort_Load(object sender, EventArgs e)
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

            string sql = "select * from GoodsSortList where 1=1 ";
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
                        sql += "and id like @id";
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
            dataGridView_GoodsTypeList.DataSource = dataTableGoodsList;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace InvoicingManagementSystem
{
    public partial class CA_checkOut : Form
    {
        public CA_checkOut()
        {
            InitializeComponent();
        }

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
            string sql = "select goods_id,goods_name,goods_type,goods_units,goods_retailPrice " +
                "from GoodsList where IsDeleted=0";
            DataTable dataTableGoodsList = SqlHelper.GetDataTable(sql);
            dataGridView_GoodsList.DataSource = dataTableGoodsList;
        }
    }
}

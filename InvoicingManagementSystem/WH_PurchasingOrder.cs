using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InvoicingManagementSystem
{
    public partial class WH_PurchasingOrder : Form
    {
        public WH_PurchasingOrder()
        {
            InitializeComponent();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            //获取查询条件
            int SearchSID = (int)comboBoxKeyword.SelectedValue;
            string keyWord = textBox_search.Text.Trim();

            string sql = "select goods_name,goods_type,goods_units," +
                "goods_purchasingCost,goods_supplier,goods_purNumber,goods_SubmitDate,goods_ShowDate," +
                "order_inventoryID,PutIn_inventoryID from orderList where IsDeleted=0 ";
            //sql += " where 1=1";

            //要改！！！！！！！！！！！！
            if (SearchSID > 0)
            {
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

                
                if (SearchSID == 5)
                {
                    //按照日期顺序排序
                    sql += "select * from orderList order by goods_SubmitDate";
                }
            }
            SqlParameter[] parameters =
            {
                new SqlParameter("@goods_name","%"+keyWord+"%"),
            };
            DataTable dataTableGoodsList = SqlHelper.GetDataTable(sql, parameters);
            dataGridView_OrderList.DataSource = dataTableGoodsList;
        }

        private void WH_PurchasingOrder_Load(object sender, EventArgs e)
        {
            InitSelect();//加载筛选列表
            SqlDataRefresh();//加载所有订单
        }

        private void InitSelect()
        {
            string sql = "select id,name from saleKeywordList where id=2 or id=5";
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
            string sql1 = "select goods_name,goods_type,goods_units," +
                "goods_purchasingCost,goods_supplier,goods_purNumber,goods_SubmitDate,goods_ShowDate," +
                "order_inventoryID,PutIn_inventoryID from orderList where IsDeleted=0";
            DataTable dataTableGoodsList = SqlHelper.GetDataTable(sql1);
            dataGridView_OrderList.DataSource = dataTableGoodsList;
        }

        /// <summary>
        /// 商品上架
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_putOut_Click(object sender, EventArgs e)
        {
            //获取数据
            if ("".Equals(lbGoods_id)||lbGoods_id==null|| 
                "".Equals(tbGoods_ShowDate) || tbGoods_ShowDate == null||
                "".Equals(tbgoods_retailPrice) || tbgoods_retailPrice == null||
                "".Equals(tbgoods_productionDate) || tbgoods_productionDate == null ||
                "".Equals(tbgoods_expirationDate) || tbgoods_expirationDate == null )
            {
                MessageBox.Show("请将商品信息补充完整！");
            }
            else
            {
                //获取数据,添加至Goods_List
                string goods_id = lbGoods_id.Text;
                string goods_name = lb_goods_name.Text;
                string goods_type= dataGridView_OrderList.Rows[flag].Cells[4].Value.ToString();
                string goods_units = dataGridView_OrderList.Rows[flag].Cells[5].Value.ToString();
                int goods_retailPrice;
                int.TryParse(tbgoods_retailPrice.Text, out goods_retailPrice);
                string goods_purchasingCost = dataGridView_OrderList.Rows[flag].Cells[6].Value.ToString();
                string goods_productionDate = tbgoods_productionDate.Text;//这里要判断是不是日期格式
                string goods_expirationDate = tbgoods_expirationDate.Text;//这里要判断是不是日期格式
                string goods_supplier = dataGridView_OrderList.Rows[flag].Cells[7].Value.ToString();
                string goods_inventory = dataGridView_OrderList.Rows[flag].Cells[8].Value.ToString();
                string goods_note = tbNote.Text;

                string sql = "insert into GoodsList (goods_id,goods_name,goods_type,goods_units," +
                    "goods_retailPrice,goods_purchasingCost,goods_productionDate,goods_expirationDate," +
                    "goods_supplier,goods_inventory,goods_note " +
                     "values (@goods_id,@goods_name,@goods_type,@goods_units,@goods_retailPrice," +
                     "@goods_purchasingCost,@goods_productionDate,@goods_expirationDate,@goods_supplier," +
                      "@goods_inventory,@goods_note)";
                SqlParameter[] parametersEdit =
                {
                    new SqlParameter("@goods_id",goods_id),
                    new SqlParameter("@goods_name",goods_name),
                    new SqlParameter("@goods_type",goods_type),
                    new SqlParameter("@goods_units",goods_units),
                    new SqlParameter("@goods_retailPrice",goods_retailPrice),
                    new SqlParameter("@goods_purchasingCost",goods_purchasingCost),
                    new SqlParameter("@goods_productionDate",goods_productionDate),
                    new SqlParameter("@goods_expirationDate",goods_expirationDate),
                    new SqlParameter("@goods_supplier",goods_supplier),
                    new SqlParameter("@goods_inventory",goods_inventory),
                    new SqlParameter("@goods_note",goods_note)
                };

                //执行并返回
                int count = SqlHelper.ExecuteNonQuery(sql, parametersEdit);

                //在orderList修改数据
                if (count > 0)
                {

                }
            }

        }

        int flag = 0;//获取选择的行

        private void dataGridView_OrderList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //获取行数据
            DataRow dataRow = (dataGridView_OrderList.Rows[e.RowIndex].DataBoundItem as DataRowView).Row;
            if (e.RowIndex != -1)
            {
                flag = e.RowIndex;
                DataGridViewCell dataGridViewCell = dataGridView_OrderList.Rows[flag].Cells[e.ColumnIndex];
                if (dataGridViewCell is DataGridViewLinkCell &&
                    dataGridViewCell.FormattedValue.ToString() == "选择")
                {
                    lb_goods_name.Text = dataGridView_OrderList.Rows[flag].Cells[3].Value.ToString();
                    tbGoods_ShowDate.Text = DateTime.Now.ToString("yyyy.MM.dd");
                }
            }
                
        }

    }
}

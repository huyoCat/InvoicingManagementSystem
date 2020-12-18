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
    public partial class AD_addGood : Form
    {
        public AD_addGood()
        {
            InitializeComponent();
        }

        //页面初始化，显示下拉列表框
        private void AD_addGood_Load(object sender, EventArgs e)
        {
            InitSelect();//加载筛选列表
        }

        private void InitSelect()
        {
            //种类下拉框
            string sql = "select id,name from GoodsSortList";
            DataTable dataTableSelectList = SqlHelper.GetDataTable(sql);
            DataRow dataRowSelectList = dataTableSelectList.NewRow();
            dataRowSelectList["id"] = 0;
            dataRowSelectList["name"] = "请选择";
            dataTableSelectList.Rows.InsertAt(dataRowSelectList, 0);

            cbgoods_type.DataSource = dataTableSelectList;
            cbgoods_type.DisplayMember = "name";
            cbgoods_type.ValueMember = "id";

            //供应商下拉框
            string sql1 = "select id,name from SupplierList";
            DataTable dataTableSelectList1 = SqlHelper.GetDataTable(sql1);
            DataRow dataRowSelectList1 = dataTableSelectList1.NewRow();
            dataRowSelectList1["id"] = 0;
            dataRowSelectList1["name"] = "请选择";
            dataTableSelectList1.Rows.InsertAt(dataRowSelectList1, 0);

            cbgoods_supplie.DataSource = dataTableSelectList1;
            cbgoods_supplie.DisplayMember = "name";
            cbgoods_supplie.ValueMember = "id";
        }


        //点击添加按钮，备注默认登记操作员名称
        private void bt_add_Click(object sender, EventArgs e)
        {
            //获取信息
            string goods_id = tbgoods_id.Text;
            string goods_name = tbgoods_name.Text;

            int id = (int)cbgoods_type.SelectedValue;
            string goods_type = SqlHelper.GetSource(id, "GoodsSortList");

            string goods_units = tbgoods_units.Text;

            int goods_retailPrice = 0;
            int goods_purchasingCost = 0;
            int.TryParse(tbgoods_retailPrice.Text, out goods_retailPrice);
            int.TryParse(tbgoods_purchasingCost.Text, out goods_purchasingCost);

            string goods_productionDate = tbgoods_productionDate.Text;
            string goods_expirationDate = tbgoods_expirationDate.Text;

            int goods_supplierID = (int)cbgoods_supplie.SelectedValue;
            string goods_supplier = SqlHelper.GetSource(goods_supplierID, "SupplierList");

            int goods_inventory = 0;
            int.TryParse(tbgoods_inventory.Text, out goods_inventory);

            string goods_note = "操作员："+LoginForm.Employee_id +"，"+ tbgoods_note.Text;

            //检查数据是否规范
            if (!SqlHelper.IsDate(goods_productionDate)
                    || !SqlHelper.IsDate(goods_expirationDate)||
                    goods_purchasingCost==0|| goods_retailPrice==0)
            {
                MessageBox.Show("请规范输入数据！");
                return;
            }
            //查看id是否已存在
            else
            {
                string sqlSelect = "select * from GoodsList where " +
                    "goods_id=@goods_id";
                SqlParameter[] parametersEdit =
                {
                    new SqlParameter("@goods_id",goods_id)
                };
                //执行并返回
                object o = SqlHelper.ExecuteScalar(sqlSelect, parametersEdit);
                if (o == null)
                {
                    //无查询结果，插入数据
                    string sqlInsert = "insert into GoodsList (goods_id,goods_name,goods_type," +
                        "goods_units,goods_retailPrice,goods_purchasingCost,goods_productionDate,goods_expirationDate," +
                        "goods_supplier,goods_inventory,goods_note) values(@goods_id,@goods_name,@goods_type," +
                        "@goods_units,@goods_retailPrice,@goods_purchasingCost,@goods_productionDate,@goods_expirationDate," +
                        "@goods_supplier,@goods_inventory,@goods_note)";
                    SqlParameter[] parametersInsert =
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
                    int count = SqlHelper.ExecuteNonQuery(sqlInsert, parametersInsert);
                    if (count > 0)
                    {
                        tbgoods_id.Text = "";
                        tbgoods_name.Text = "";
                        cbgoods_type.SelectedIndex = 0;
                        tbgoods_units.Text = "";
                        tbgoods_retailPrice.Text = "";
                        tbgoods_purchasingCost.Text = "";
                        tbgoods_productionDate.Text = "";
                        tbgoods_expirationDate.Text = "";
                        cbgoods_supplie.SelectedIndex = 0;
                        tbgoods_inventory.Text = "0";
                        tbgoods_note.Text = "";
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
                    MessageBox.Show("该商品编号已存在！");
                    return;
                }
            }
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

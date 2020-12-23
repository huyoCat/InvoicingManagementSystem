using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InvoicingManagementSystem
{
    public partial class AD_EditGoodInfo : Form
    {
        public AD_EditGoodInfo()
        {
            InitializeComponent();
        }

        private string goods_id = null;
        private string goods_type = null;
        private string goods_supplier = null;
        private Action reLaod = null;

        private void AD_EditGoodInfo_Load(object sender, EventArgs e)
        {
            InitSelect();//加载类别列表
            //加载商品信息
            InitBookInfo();
        }

        private void InitSelect()
        {
            //种类下拉框
            string sql = "select id,name from GoodsSortList";
            DataTable dataTableSelectList = SqlHelper.GetDataTable(sql);
            cbgoods_type.DataSource = dataTableSelectList;
            cbgoods_type.DisplayMember = "name";
            cbgoods_type.ValueMember = "id";


            //供应商下拉框
            string sql1 = "select id,name from SupplierList";
            DataTable dataTableSelectList1 = SqlHelper.GetDataTable(sql1);
            cbgoods_supplie.DataSource = dataTableSelectList1;
            cbgoods_supplie.DisplayMember = "name";
            cbgoods_supplie.ValueMember = "id";
        }

        private void InitBookInfo()
        {
            if (this.Tag != null)
            {
                TagObject tagObject = (TagObject)this.Tag;
                goods_id = tagObject.goods_id;
                goods_type = tagObject.goods_type;
                goods_supplier = tagObject.goods_supplier;
                reLaod = tagObject.ReLoad;//赋值
            }
            //查询
            string sql = "select * from GoodsList where goods_id=@goods_id";
            SqlParameter paraID = new SqlParameter("@goods_id", goods_id);
            SqlDataReader dataReader = SqlHelper.ExecuteReader(sql, paraID);
            tbgoods_id.Text = goods_id;
            //读取数据
            if (dataReader.Read())
            {
                tbgoods_name.Text = dataReader["goods_name"].ToString();
                tbgoods_units.Text = dataReader["goods_units"].ToString();
                tbgoods_retailPrice.Text = dataReader["goods_retailPrice"].ToString();
                tbgoods_purchasingCost.Text = dataReader["goods_purchasingCost"].ToString();
                tbgoods_productionDate.Text = DateTime.Parse(dataReader["goods_productionDate"].ToString()).ToString("yyyy.MM.dd");
                tbgoods_expirationDate.Text = DateTime.Parse(dataReader["goods_expirationDate"].ToString()).ToString("yyyy.MM.dd");
                //DateTime.Now.ToString("yyyy.MM.dd");

                tbgoods_inventory.Text = dataReader["goods_inventory"].ToString();
                tbgoods_note.Text = dataReader["goods_note"].ToString();
            }
            dataReader.Close();

            int goods_typeId = SqlHelper.GetId(goods_type, "GoodsSortList");
            string sql1 = "select id,name from GoodsSortList";
            DataTable dataTableSelectSort = SqlHelper.GetDataTable(sql1);
            cbgoods_type.DataSource = dataTableSelectSort;
            cbgoods_type.DisplayMember = "name";
            cbgoods_type.ValueMember = "id";
            cbgoods_type.SelectedIndex = goods_typeId - 1;//从0开始算所以要减一


            int goods_supplierID = SqlHelper.GetId(goods_supplier, "SupplierList");
            string sql2 = "select id,name from SupplierList";
            DataTable dataTableSelectSort2 = SqlHelper.GetDataTable(sql2);
            cbgoods_supplie.DataSource = dataTableSelectSort2;
            cbgoods_supplie.DisplayMember = "name";
            cbgoods_supplie.ValueMember = "id";
            cbgoods_supplie.SelectedIndex = goods_supplierID - 1;
        }



        /// <summary>
        /// 提交修改结果
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_update_Click(object sender, EventArgs e)
        {
            TagObject tagObject = (TagObject)this.Tag;
            string IsEdit = tagObject.goods_id;
            //获取信息
            string goods_id = tbgoods_id.Text;
            string goods_name = tbgoods_name.Text;

            int id = (int)cbgoods_type.SelectedValue;
            string goods_type = SqlHelper.GetSource(id, "GoodsSortList");

            string goods_units = tbgoods_units.Text;

            double goods_retailPrice = 0;
            double goods_purchasingCost = 0;
            double.TryParse(tbgoods_retailPrice.Text, out goods_retailPrice);
            double.TryParse(tbgoods_purchasingCost.Text, out goods_purchasingCost);

            string goods_productionDate = tbgoods_productionDate.Text;
            string goods_expirationDate = tbgoods_expirationDate.Text;

            int goods_supplierID = (int)cbgoods_supplie.SelectedValue;
            string goods_supplier = SqlHelper.GetSource(goods_supplierID, "SupplierList");

            int goods_inventory = 0;
            int.TryParse(tbgoods_inventory.Text, out goods_inventory);

            string goods_note = "操作员：" + LoginForm.Employee_id + "，" + tbgoods_note.Text;

            //检查数据是否规范
            if (!SqlHelper.IsDate(goods_productionDate)
                    || !SqlHelper.IsDate(goods_expirationDate) ||
                    goods_purchasingCost == 0 || goods_retailPrice == 0)
            {
                MessageBox.Show("请规范输入数据！");
                return;
            }
            //查看id是否已存在
            else
            {
                //如果编号修改了
                if (!IsEdit.Equals(goods_id))
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
                        string Oid = tagObject.goods_id;
                        //无查询结果，插入数据
                        string sqlInsert = "update GoodsList set goods_name=@goods_name where goods_id='" + Oid +
                            "' update GoodsList set goods_type=@goods_type where goods_id='" + Oid +
                            "' update GoodsList set goods_units=@goods_units where goods_id='" + Oid +
                            "' update GoodsList set goods_retailPrice=@goods_retailPrice where goods_id='" + Oid +
                            "' update GoodsList set goods_purchasingCost=@goods_purchasingCost where goods_id='" + Oid +
                            "' update GoodsList set goods_productionDate=@goods_productionDate where goods_id='" + Oid +
                            "' update GoodsList set goods_expirationDate=@goods_expirationDate where goods_id='" + Oid +
                            "' update GoodsList set goods_supplier=@goods_supplier where goods_id='" + Oid +
                            "' update GoodsList set goods_inventory=@goods_inventory where goods_id='" + Oid +
                            "' update GoodsList set goods_note=@goods_note where goods_id='" + Oid +
                            "' update GoodsList set goods_id=@goods_id where goods_id='" + Oid + "'";
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
                            MessageBox.Show("修改成功！");
                            //利用委托跨页面刷新
                            reLaod.Invoke();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("修改失败！");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("该商品编号已存在！");
                        return;
                    }
                }
                //编号没有修改
                else
                {
                    string Oid = tagObject.goods_id;
                    //无查询结果，插入数据
                    string sqlInsert = "update GoodsList set goods_name=@goods_name where goods_id='" + Oid +
                        "' update GoodsList set goods_type=@goods_type where goods_id='" + Oid +
                        "' update GoodsList set goods_units=@goods_units where goods_id='" + Oid +
                        "' update GoodsList set goods_retailPrice=@goods_retailPrice where goods_id='" + Oid +
                        "' update GoodsList set goods_purchasingCost=@goods_purchasingCost where goods_id='" + Oid +
                        "' update GoodsList set goods_productionDate=@goods_productionDate where goods_id='" + Oid +
                        "' update GoodsList set goods_expirationDate=@goods_expirationDate where goods_id='" + Oid +
                        "' update GoodsList set goods_supplier=@goods_supplier where goods_id='" + Oid +
                        "' update GoodsList set goods_inventory=@goods_inventory where goods_id='" + Oid +
                        "' update GoodsList set goods_note=@goods_note where goods_id='" + Oid +
                        "' update GoodsList set goods_id=@goods_id where goods_id='" + Oid + "'";
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
                        MessageBox.Show("修改成功！");
                        //利用委托跨页面刷新
                        reLaod.Invoke();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("修改失败！");
                        return;
                    }
                }
            }
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

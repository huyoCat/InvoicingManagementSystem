using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoicingManagementSystem
{
    public partial class AD_FormMain : Form
    {
        public AD_FormMain()
        {
            InitializeComponent();
        }

        private void add_CA_Click(object sender, EventArgs e)
        {
            AD_addCA addCA = new AD_addCA();
            addCA.MdiParent = this;//MdiParent用来规定父窗体
            addCA.Show();
        }

        private void add_WH_Click(object sender, EventArgs e)
        {
            AD_addWH addwh = new AD_addWH();
            addwh.MdiParent = this;//MdiParent用来规定父窗体
            addwh.Show();
        }

        private void add_AD_Click(object sender, EventArgs e)
        {
            AD_addAD addAD = new AD_addAD();
            addAD.MdiParent = this;//MdiParent用来规定父窗体
            addAD.Show();
        }

        private void add_type_Click(object sender, EventArgs e)
        {
            AD_addGoodType addType = new AD_addGoodType();
            addType.MdiParent = this;//MdiParent用来规定父窗体
            addType.Show();
        }

        private void add_good_Click(object sender, EventArgs e)
        {
            AD_addGood addGood = new AD_addGood();
            addGood.MdiParent = this;//MdiParent用来规定父窗体
            addGood.Show();
        }

        private void add_supplier_Click(object sender, EventArgs e)
        {
            AD_addSupplier addSupplier = new AD_addSupplier();
            addSupplier.MdiParent = this;//MdiParent用来规定父窗体
            addSupplier.Show();
        }

        private void select_goodsList_Click(object sender, EventArgs e)
        {
            AD_select_goodsList addSupplier = new AD_select_goodsList();
            addSupplier.MdiParent = this;//MdiParent用来规定父窗体
            addSupplier.Show();
        }

        private void exitSystem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AD_FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("您确定要退出系统吗？", "退出提示",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void select_orderList_Click(object sender, EventArgs e)
        {
            AD_select_orderList addSupplier = new AD_select_orderList();
            addSupplier.MdiParent = this;//MdiParent用来规定父窗体
            addSupplier.Show();
        }

        private void select_salesList_Click(object sender, EventArgs e)
        {
            AD_select_salesList addSupplier = new AD_select_salesList();
            addSupplier.MdiParent = this;//MdiParent用来规定父窗体
            addSupplier.Show();
        }

        private void select_employee_Click(object sender, EventArgs e)
        {
            AD_select_employee addSupplier = new AD_select_employee();
            addSupplier.MdiParent = this;//MdiParent用来规定父窗体
            addSupplier.Show();
        }

        private void select_Supplier_Click(object sender, EventArgs e)
        {
            AD_select_Supplier addSupplier = new AD_select_Supplier();
            addSupplier.MdiParent = this;//MdiParent用来规定父窗体
            addSupplier.Show();
        }

        private void select_GoodsSort_Click(object sender, EventArgs e)
        {
            AD_select_GoodsSort addSupplier = new AD_select_GoodsSort();
            addSupplier.MdiParent = this;//MdiParent用来规定父窗体
            addSupplier.Show();
        }
    }
}

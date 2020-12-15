using System;
using System.Windows.Forms;

namespace InvoicingManagementSystem
{
    public partial class WH_FormMain : Form
    {
        public WH_FormMain()
        {
            InitializeComponent();
        }

        private void selectInventory_click(object sender, EventArgs e)
        {
            WH_SelectInventory SelectInventory = new WH_SelectInventory();
            SelectInventory.MdiParent = this;//MdiParent用来规定父窗体
            SelectInventory.Show();
        }

        private void purchasingOrder_click(object sender, EventArgs e)
        {
            WH_PurchasingOrder purchasingOrder = new WH_PurchasingOrder();
            purchasingOrder.MdiParent = this;//MdiParent用来规定父窗体
            purchasingOrder.Show();
        }

        private void Exit_click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void WH_FormMain_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}

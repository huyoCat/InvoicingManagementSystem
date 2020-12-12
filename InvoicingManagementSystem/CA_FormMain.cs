using System;
using System.Windows.Forms;

namespace InvoicingManagementSystem
{
    public partial class CA_FormMain : Form
    {
        public CA_FormMain()
        {
            InitializeComponent();
        }

        private void checkout_Click(object sender, EventArgs e)
        {
            CA_checkOut checkout = new CA_checkOut();
            checkout.MdiParent = this;//MdiParent用来规定父窗体
            checkout.Show();
        }

        private void history_Click(object sender, EventArgs e)
        {
            CA_history cA_History = new CA_history();
            cA_History.MdiParent = this;//MdiParent用来规定父窗体
            cA_History.Show();
        }


        //退出系统
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CAFormMain_FormClosing(object sender, FormClosingEventArgs e)
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

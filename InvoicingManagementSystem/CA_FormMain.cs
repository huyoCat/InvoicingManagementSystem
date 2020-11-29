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
    }
}

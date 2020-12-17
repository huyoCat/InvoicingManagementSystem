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
    }
}

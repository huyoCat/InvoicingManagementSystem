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
    public partial class AD_addCA : Form
    {
        public AD_addCA()
        {
            InitializeComponent();
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            string id = tb_id.Text;
            string name = tb_name.Text;
            string pwd = tb_pwd.Text;
            string identify = "收银员";

            if ("".Equals(id) || id == null ||
                "".Equals(name) || name == null ||
                "".Equals(pwd) || pwd == null ||
                "".Equals(identify) || identify == null)
            {
                MessageBox.Show("请将信息填写完整！");
                return;
            }
            else
            {
                string sql = "insert into EmployeeList values(@id,@name,@pwd,@identify)";
                SqlParameter[] parametersInsert =
                {
                new SqlParameter("@id",id),
                new SqlParameter("@name",name),
                new SqlParameter("@pwd",pwd),
                new SqlParameter("@identify",identify)
            };

                //执行并返回
                int count = SqlHelper.ExecuteNonQuery(sql, parametersInsert);
                if (count < 1)
                {
                    MessageBox.Show("添加失败！");
                }
                else
                {
                    tb_id.Text = "";
                    tb_name.Text = "";
                    tb_pwd.Text = "";
                    MessageBox.Show("添加成功！");
                }
            }
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

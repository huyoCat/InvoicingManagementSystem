using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InvoicingManagementSystem
{
    public partial class AD_addAD : Form
    {
        public AD_addAD()
        {
            InitializeComponent();
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            string Employee_id = tb_id.Text;
            string Employee_name = tb_name.Text;
            string Employee_password = tb_pwd.Text;
            string Employee_identify = "管理员";

            //判断信息是否填写完整
            if ("".Equals(Employee_id) || Employee_id == null ||
                "".Equals(Employee_name) || Employee_name == null ||
                "".Equals(Employee_password) || Employee_password == null ||
                "".Equals(Employee_identify) || Employee_identify == null)
            {
                MessageBox.Show("请将信息填写完整！");
                return;
            }
            else
            {
                //查询是否已存在
                string sqlSelect = "select * from EmployeeList where " +
                "Employee_id=@Employee_id";
                SqlParameter[] parametersEdit =
                {
                    new SqlParameter("@Employee_id",Employee_id)
                };
                //执行并返回
                object o = SqlHelper.ExecuteScalar(sqlSelect, parametersEdit);
                if (o == null)
                {
                    string sql = "insert into EmployeeList values(@Employee_id,@Employee_name,@Employee_password,@Employee_identify)";
                    SqlParameter[] parametersInsert =
                    {
                        new SqlParameter("@Employee_id",Employee_id),
                        new SqlParameter("@Employee_name",Employee_name),
                        new SqlParameter("@Employee_password",Employee_password),
                        new SqlParameter("@Employee_identify",Employee_identify)
                    };

                    //执行并返回
                    int count = SqlHelper.ExecuteNonQuery(sql, parametersInsert);
                    if (count < 1)
                    {
                        MessageBox.Show("添加失败！");
                        return;
                    }
                    else
                    {
                        tb_id.Text = "";
                        tb_name.Text = "";
                        tb_pwd.Text = "";
                        MessageBox.Show("添加成功！");
                    }
                }

                else
                {
                    MessageBox.Show("该账号已存在！");
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

using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InvoicingManagementSystem
{
    public partial class LoginForm : Form
    {
        public static string Employee_id;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            //获取用户输入信息
            string id = textBox_Num.Text.Trim();//账号
            string password = textBox_password.Text.Trim();//密码
            string iden = "";

            //判断身份
            if (Login_cashier.Checked)//收银员
            {
                iden = Login_cashier.Text;
            }
            if (Login_warehouseKeeper.Checked)//仓库管理员
            {
                iden = Login_warehouseKeeper.Text;
            }
            if (Login_administrator.Checked)//管理员
            {
                iden = Login_administrator.Text;
            }


            //判断是否为空
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("请输入账号", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_Num.Focus();
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("请输入密码", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_password.Focus();
                return;
            }

            //与数据库通信，检查输入与数据库记录是否一致
            {
                //建立与数据库的连接,根据返回结果显示不同提示
                {
                    string sql = "select count(1) from EmployeeList " +
                        "where Employee_id=@Employee_id and " +
                        "Employee_password=@Employee_password and " +
                        "Employee_identify=@Employee_identify";

                    SqlParameter[] parameters =
                    {
                        new SqlParameter("@Employee_id", id),
                        new SqlParameter("@Employee_password", password),
                        new SqlParameter("@Employee_identify",iden)
                    };

                    object o = SqlHelper.ExecuteScalar(sql, parameters);

                    //处理结果
                    if (o == null || o == DBNull.Value || ((int)o == 0))
                    {
                        MessageBox.Show("账号或密码有误！", "登录提示",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    else
                    {
                        int count = (int)o;//不知道是用来做什么的了
                        Employee_id = id;//传值，登记各种表的操作员
                        //CA_checkOut cA_Check = new CA_checkOut();
                        //cA_Check.Tag = Employee_id;

                        MessageBox.Show("登录成功！", "登录提示",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //转到不同的主页面
                        {
                            if(iden== "管理员")
                            {
                                AD_FormMain formMain = new AD_FormMain();
                                formMain.Show();
                            }
                            if (iden == "收银员")
                            {
                                CA_FormMain formMain = new CA_FormMain();
                                formMain.Show();
                            }
                            if (iden == "仓库管理员")
                            {
                                WH_FormMain formMain = new WH_FormMain();
                                formMain.Show();
                            }
                        }
                        this.Hide();
                    }
                }
            }
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            Login_administrator.Checked = true;
        }
    }
}

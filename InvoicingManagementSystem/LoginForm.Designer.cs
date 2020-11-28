namespace InvoicingManagementSystem
{
    partial class LoginForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Login_warehouseKeeper = new System.Windows.Forms.RadioButton();
            this.Login_cashier = new System.Windows.Forms.RadioButton();
            this.button_Exit = new System.Windows.Forms.Button();
            this.button_Login = new System.Windows.Forms.Button();
            this.label_password = new System.Windows.Forms.Label();
            this.label_ID = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.textBox_Num = new System.Windows.Forms.TextBox();
            this.Login_financialManager = new System.Windows.Forms.RadioButton();
            this.Login_administrator = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // Login_warehouseKeeper
            // 
            this.Login_warehouseKeeper.AutoSize = true;
            this.Login_warehouseKeeper.Location = new System.Drawing.Point(176, 171);
            this.Login_warehouseKeeper.Name = "Login_warehouseKeeper";
            this.Login_warehouseKeeper.Size = new System.Drawing.Size(83, 16);
            this.Login_warehouseKeeper.TabIndex = 21;
            this.Login_warehouseKeeper.TabStop = true;
            this.Login_warehouseKeeper.Text = "仓库管理员";
            this.Login_warehouseKeeper.UseVisualStyleBackColor = true;
            // 
            // Login_cashier
            // 
            this.Login_cashier.AutoSize = true;
            this.Login_cashier.Location = new System.Drawing.Point(71, 210);
            this.Login_cashier.Name = "Login_cashier";
            this.Login_cashier.Size = new System.Drawing.Size(59, 16);
            this.Login_cashier.TabIndex = 20;
            this.Login_cashier.TabStop = true;
            this.Login_cashier.Text = "收银员";
            this.Login_cashier.UseVisualStyleBackColor = true;
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(197, 260);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(62, 23);
            this.button_Exit.TabIndex = 19;
            this.button_Exit.Text = "退出";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // button_Login
            // 
            this.button_Login.Location = new System.Drawing.Point(71, 260);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(62, 23);
            this.button_Login.TabIndex = 18;
            this.button_Login.Text = "登录";
            this.button_Login.UseVisualStyleBackColor = true;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(69, 102);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(29, 12);
            this.label_password.TabIndex = 17;
            this.label_password.Text = "密码";
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Location = new System.Drawing.Point(69, 27);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(29, 12);
            this.label_ID.TabIndex = 16;
            this.label_ID.Text = "账号";
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(115, 99);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new System.Drawing.Size(144, 21);
            this.textBox_password.TabIndex = 15;
            // 
            // textBox_Num
            // 
            this.textBox_Num.Location = new System.Drawing.Point(115, 24);
            this.textBox_Num.Name = "textBox_Num";
            this.textBox_Num.Size = new System.Drawing.Size(144, 21);
            this.textBox_Num.TabIndex = 14;
            // 
            // Login_financialManager
            // 
            this.Login_financialManager.AutoSize = true;
            this.Login_financialManager.Location = new System.Drawing.Point(176, 210);
            this.Login_financialManager.Name = "Login_financialManager";
            this.Login_financialManager.Size = new System.Drawing.Size(83, 16);
            this.Login_financialManager.TabIndex = 22;
            this.Login_financialManager.TabStop = true;
            this.Login_financialManager.Text = "财务管理员";
            this.Login_financialManager.UseVisualStyleBackColor = true;
            // 
            // Login_administrator
            // 
            this.Login_administrator.AutoSize = true;
            this.Login_administrator.Location = new System.Drawing.Point(71, 171);
            this.Login_administrator.Name = "Login_administrator";
            this.Login_administrator.Size = new System.Drawing.Size(59, 16);
            this.Login_administrator.TabIndex = 23;
            this.Login_administrator.TabStop = true;
            this.Login_administrator.Text = "管理员";
            this.Login_administrator.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 316);
            this.Controls.Add(this.Login_administrator);
            this.Controls.Add(this.Login_financialManager);
            this.Controls.Add(this.Login_warehouseKeeper);
            this.Controls.Add(this.Login_cashier);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_ID);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_Num);
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton Login_warehouseKeeper;
        private System.Windows.Forms.RadioButton Login_cashier;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.TextBox textBox_Num;
        private System.Windows.Forms.RadioButton Login_financialManager;
        private System.Windows.Forms.RadioButton Login_administrator;
    }
}


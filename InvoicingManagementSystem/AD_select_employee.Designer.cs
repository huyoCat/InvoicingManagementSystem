namespace InvoicingManagementSystem
{
    partial class AD_select_employee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxKeyword = new System.Windows.Forms.ComboBox();
            this.dataGridView_EmployeeList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btSearch = new System.Windows.Forms.Button();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.ColChecked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Employee_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Employee_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Employee_password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Employee_identify = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_EmployeeList)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxKeyword
            // 
            this.comboBoxKeyword.FormattingEnabled = true;
            this.comboBoxKeyword.Location = new System.Drawing.Point(95, 5);
            this.comboBoxKeyword.Name = "comboBoxKeyword";
            this.comboBoxKeyword.Size = new System.Drawing.Size(97, 20);
            this.comboBoxKeyword.TabIndex = 21;
            // 
            // dataGridView_EmployeeList
            // 
            this.dataGridView_EmployeeList.AllowUserToAddRows = false;
            this.dataGridView_EmployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_EmployeeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColChecked,
            this.Employee_id,
            this.Employee_name,
            this.Employee_password,
            this.Employee_identify});
            this.dataGridView_EmployeeList.Location = new System.Drawing.Point(21, 42);
            this.dataGridView_EmployeeList.Name = "dataGridView_EmployeeList";
            this.dataGridView_EmployeeList.RowTemplate.Height = 23;
            this.dataGridView_EmployeeList.Size = new System.Drawing.Size(495, 299);
            this.dataGridView_EmployeeList.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 19;
            this.label1.Text = "选择查询方式";
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(351, 5);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(56, 21);
            this.btSearch.TabIndex = 18;
            this.btSearch.Text = "搜索";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(198, 5);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(137, 21);
            this.textBox_search.TabIndex = 17;
            // 
            // ColChecked
            // 
            this.ColChecked.HeaderText = "选择";
            this.ColChecked.Name = "ColChecked";
            this.ColChecked.Width = 50;
            // 
            // Employee_id
            // 
            this.Employee_id.DataPropertyName = "Employee_id";
            this.Employee_id.HeaderText = "员工编号";
            this.Employee_id.Name = "Employee_id";
            this.Employee_id.ReadOnly = true;
            // 
            // Employee_name
            // 
            this.Employee_name.DataPropertyName = "Employee_name";
            this.Employee_name.HeaderText = "员工姓名";
            this.Employee_name.Name = "Employee_name";
            this.Employee_name.ReadOnly = true;
            // 
            // Employee_password
            // 
            this.Employee_password.DataPropertyName = "Employee_password";
            this.Employee_password.HeaderText = "密码";
            this.Employee_password.Name = "Employee_password";
            this.Employee_password.ReadOnly = true;
            // 
            // Employee_identify
            // 
            this.Employee_identify.DataPropertyName = "Employee_identify";
            this.Employee_identify.HeaderText = "职务";
            this.Employee_identify.Name = "Employee_identify";
            this.Employee_identify.ReadOnly = true;
            // 
            // AD_select_employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 360);
            this.Controls.Add(this.comboBoxKeyword);
            this.Controls.Add(this.dataGridView_EmployeeList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.textBox_search);
            this.Name = "AD_select_employee";
            this.Text = "查询员工信息";
            this.Load += new System.EventHandler(this.AD_select_employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_EmployeeList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxKeyword;
        private System.Windows.Forms.DataGridView dataGridView_EmployeeList;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColChecked;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee_password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee_identify;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.TextBox textBox_search;
    }
}
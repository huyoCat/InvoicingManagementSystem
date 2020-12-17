namespace InvoicingManagementSystem
{
    partial class AD_FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.staffMana = new System.Windows.Forms.ToolStripMenuItem();
            this.goodsMana = new System.Windows.Forms.ToolStripMenuItem();
            this.exitSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.add_CA = new System.Windows.Forms.ToolStripMenuItem();
            this.add_WH = new System.Windows.Forms.ToolStripMenuItem();
            this.add_AD = new System.Windows.Forms.ToolStripMenuItem();
            this.add_type = new System.Windows.Forms.ToolStripMenuItem();
            this.add_good = new System.Windows.Forms.ToolStripMenuItem();
            this.add_supplier = new System.Windows.Forms.ToolStripMenuItem();
            this.select_table = new System.Windows.Forms.ToolStripMenuItem();
            this.select_goodsList = new System.Windows.Forms.ToolStripMenuItem();
            this.select_orderList = new System.Windows.Forms.ToolStripMenuItem();
            this.select_salesList = new System.Windows.Forms.ToolStripMenuItem();
            this.select_employee = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.staffMana,
            this.goodsMana,
            this.select_table,
            this.exitSystem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(717, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // staffMana
            // 
            this.staffMana.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add_CA,
            this.add_WH,
            this.add_AD});
            this.staffMana.Name = "staffMana";
            this.staffMana.Size = new System.Drawing.Size(68, 21);
            this.staffMana.Text = "员工管理";
            // 
            // goodsMana
            // 
            this.goodsMana.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add_type,
            this.add_good,
            this.add_supplier});
            this.goodsMana.Name = "goodsMana";
            this.goodsMana.Size = new System.Drawing.Size(68, 21);
            this.goodsMana.Text = "商品管理";
            // 
            // exitSystem
            // 
            this.exitSystem.Name = "exitSystem";
            this.exitSystem.Size = new System.Drawing.Size(68, 21);
            this.exitSystem.Text = "退出系统";
            // 
            // add_CA
            // 
            this.add_CA.Name = "add_CA";
            this.add_CA.Size = new System.Drawing.Size(180, 22);
            this.add_CA.Text = "添加收银员";
            this.add_CA.Click += new System.EventHandler(this.add_CA_Click);
            // 
            // add_WH
            // 
            this.add_WH.Name = "add_WH";
            this.add_WH.Size = new System.Drawing.Size(180, 22);
            this.add_WH.Text = "添加仓库管理员";
            this.add_WH.Click += new System.EventHandler(this.add_WH_Click);
            // 
            // add_AD
            // 
            this.add_AD.Name = "add_AD";
            this.add_AD.Size = new System.Drawing.Size(180, 22);
            this.add_AD.Text = "添加管理员";
            this.add_AD.Click += new System.EventHandler(this.add_AD_Click);
            // 
            // add_type
            // 
            this.add_type.Name = "add_type";
            this.add_type.Size = new System.Drawing.Size(180, 22);
            this.add_type.Text = "添加商品种类";
            this.add_type.Click += new System.EventHandler(this.add_type_Click);
            // 
            // add_good
            // 
            this.add_good.Name = "add_good";
            this.add_good.Size = new System.Drawing.Size(180, 22);
            this.add_good.Text = "添加商品";
            // 
            // add_supplier
            // 
            this.add_supplier.Name = "add_supplier";
            this.add_supplier.Size = new System.Drawing.Size(180, 22);
            this.add_supplier.Text = "添加供应商";
            // 
            // select_table
            // 
            this.select_table.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.select_goodsList,
            this.select_orderList,
            this.select_salesList,
            this.select_employee});
            this.select_table.Name = "select_table";
            this.select_table.Size = new System.Drawing.Size(44, 21);
            this.select_table.Text = "查询";
            // 
            // select_goodsList
            // 
            this.select_goodsList.Name = "select_goodsList";
            this.select_goodsList.Size = new System.Drawing.Size(180, 22);
            this.select_goodsList.Text = "查询商品列表";
            // 
            // select_orderList
            // 
            this.select_orderList.Name = "select_orderList";
            this.select_orderList.Size = new System.Drawing.Size(180, 22);
            this.select_orderList.Text = "查询订单";
            // 
            // select_salesList
            // 
            this.select_salesList.Name = "select_salesList";
            this.select_salesList.Size = new System.Drawing.Size(180, 22);
            this.select_salesList.Text = "查询已售商品";
            // 
            // select_employee
            // 
            this.select_employee.Name = "select_employee";
            this.select_employee.Size = new System.Drawing.Size(180, 22);
            this.select_employee.Text = "查询员工表";
            // 
            // AD_FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 361);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "AD_FormMain";
            this.Text = "管理员";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem staffMana;
        private System.Windows.Forms.ToolStripMenuItem goodsMana;
        private System.Windows.Forms.ToolStripMenuItem exitSystem;
        private System.Windows.Forms.ToolStripMenuItem add_CA;
        private System.Windows.Forms.ToolStripMenuItem add_WH;
        private System.Windows.Forms.ToolStripMenuItem add_AD;
        private System.Windows.Forms.ToolStripMenuItem add_type;
        private System.Windows.Forms.ToolStripMenuItem add_good;
        private System.Windows.Forms.ToolStripMenuItem add_supplier;
        private System.Windows.Forms.ToolStripMenuItem select_table;
        private System.Windows.Forms.ToolStripMenuItem select_goodsList;
        private System.Windows.Forms.ToolStripMenuItem select_orderList;
        private System.Windows.Forms.ToolStripMenuItem select_salesList;
        private System.Windows.Forms.ToolStripMenuItem select_employee;
    }
}
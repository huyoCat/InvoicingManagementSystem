namespace InvoicingManagementSystem
{
    partial class CA_FormMain
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
            this.checkout = new System.Windows.Forms.ToolStripMenuItem();
            this.checkTheOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.exitSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkout,
            this.checkTheOrder,
            this.exitSystem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(640, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // checkout
            // 
            this.checkout.Name = "checkout";
            this.checkout.Size = new System.Drawing.Size(68, 21);
            this.checkout.Text = "办理结账";
            this.checkout.Click += new System.EventHandler(this.checkout_Click);
            // 
            // checkTheOrder
            // 
            this.checkTheOrder.Name = "checkTheOrder";
            this.checkTheOrder.Size = new System.Drawing.Size(92, 21);
            this.checkTheOrder.Text = "查询历史交易";
            // 
            // exitSystem
            // 
            this.exitSystem.Name = "exitSystem";
            this.exitSystem.Size = new System.Drawing.Size(68, 21);
            this.exitSystem.Text = "退出系统";
            // 
            // CA_FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 405);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CA_FormMain";
            this.Text = "收银界面";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem checkout;
        private System.Windows.Forms.ToolStripMenuItem checkTheOrder;
        private System.Windows.Forms.ToolStripMenuItem exitSystem;
    }
}
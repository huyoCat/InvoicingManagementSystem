namespace InvoicingManagementSystem
{
    partial class AD_addGood
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
            this.bt_cancel = new System.Windows.Forms.Button();
            this.bt_add = new System.Windows.Forms.Button();
            this.tbgoods_units = new System.Windows.Forms.TextBox();
            this.tbgoods_name = new System.Windows.Forms.TextBox();
            this.tbgoods_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbgoods_retailPrice = new System.Windows.Forms.TextBox();
            this.tbgoods_purchasingCost = new System.Windows.Forms.TextBox();
            this.tbgoods_productionDate = new System.Windows.Forms.TextBox();
            this.tbgoods_expirationDate = new System.Windows.Forms.TextBox();
            this.tbgoods_inventory = new System.Windows.Forms.TextBox();
            this.tbgoods_note = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbgoods_type = new System.Windows.Forms.ComboBox();
            this.cbgoods_supplie = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // bt_cancel
            // 
            this.bt_cancel.Location = new System.Drawing.Point(527, 265);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(75, 23);
            this.bt_cancel.TabIndex = 35;
            this.bt_cancel.Text = "取消";
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // bt_add
            // 
            this.bt_add.Location = new System.Drawing.Point(374, 265);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(75, 23);
            this.bt_add.TabIndex = 34;
            this.bt_add.Text = "添加";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // tbgoods_units
            // 
            this.tbgoods_units.Location = new System.Drawing.Point(117, 165);
            this.tbgoods_units.Name = "tbgoods_units";
            this.tbgoods_units.Size = new System.Drawing.Size(149, 21);
            this.tbgoods_units.TabIndex = 33;
            // 
            // tbgoods_name
            // 
            this.tbgoods_name.Location = new System.Drawing.Point(117, 77);
            this.tbgoods_name.Name = "tbgoods_name";
            this.tbgoods_name.Size = new System.Drawing.Size(149, 21);
            this.tbgoods_name.TabIndex = 32;
            // 
            // tbgoods_id
            // 
            this.tbgoods_id.Location = new System.Drawing.Point(117, 36);
            this.tbgoods_id.Name = "tbgoods_id";
            this.tbgoods_id.Size = new System.Drawing.Size(149, 21);
            this.tbgoods_id.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 30;
            this.label4.Text = "商品名称：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 29;
            this.label3.Text = "商品单位：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 28;
            this.label2.Text = "商品编号：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 27;
            this.label1.Text = "请输入商品信息：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 36;
            this.label5.Text = "商品种类：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 37;
            this.label6.Text = "零售价：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 38;
            this.label7.Text = "进购价：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(359, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 39;
            this.label8.Text = "生产日期：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(359, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 40;
            this.label9.Text = "保质日期：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(359, 168);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 41;
            this.label10.Text = "商品库存：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(359, 217);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 42;
            this.label11.Text = "备注：";
            // 
            // tbgoods_retailPrice
            // 
            this.tbgoods_retailPrice.Location = new System.Drawing.Point(117, 214);
            this.tbgoods_retailPrice.Name = "tbgoods_retailPrice";
            this.tbgoods_retailPrice.Size = new System.Drawing.Size(149, 21);
            this.tbgoods_retailPrice.TabIndex = 43;
            // 
            // tbgoods_purchasingCost
            // 
            this.tbgoods_purchasingCost.Location = new System.Drawing.Point(117, 256);
            this.tbgoods_purchasingCost.Name = "tbgoods_purchasingCost";
            this.tbgoods_purchasingCost.Size = new System.Drawing.Size(149, 21);
            this.tbgoods_purchasingCost.TabIndex = 44;
            // 
            // tbgoods_productionDate
            // 
            this.tbgoods_productionDate.Location = new System.Drawing.Point(453, 36);
            this.tbgoods_productionDate.Name = "tbgoods_productionDate";
            this.tbgoods_productionDate.Size = new System.Drawing.Size(149, 21);
            this.tbgoods_productionDate.TabIndex = 45;
            // 
            // tbgoods_expirationDate
            // 
            this.tbgoods_expirationDate.Location = new System.Drawing.Point(453, 77);
            this.tbgoods_expirationDate.Name = "tbgoods_expirationDate";
            this.tbgoods_expirationDate.Size = new System.Drawing.Size(149, 21);
            this.tbgoods_expirationDate.TabIndex = 46;
            // 
            // tbgoods_inventory
            // 
            this.tbgoods_inventory.Location = new System.Drawing.Point(453, 165);
            this.tbgoods_inventory.Name = "tbgoods_inventory";
            this.tbgoods_inventory.Size = new System.Drawing.Size(149, 21);
            this.tbgoods_inventory.TabIndex = 47;
            this.tbgoods_inventory.Text = "0";
            // 
            // tbgoods_note
            // 
            this.tbgoods_note.Location = new System.Drawing.Point(453, 214);
            this.tbgoods_note.Name = "tbgoods_note";
            this.tbgoods_note.Size = new System.Drawing.Size(149, 21);
            this.tbgoods_note.TabIndex = 48;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(359, 124);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 49;
            this.label12.Text = "供应商：";
            // 
            // cbgoods_type
            // 
            this.cbgoods_type.FormattingEnabled = true;
            this.cbgoods_type.Location = new System.Drawing.Point(117, 124);
            this.cbgoods_type.Name = "cbgoods_type";
            this.cbgoods_type.Size = new System.Drawing.Size(149, 20);
            this.cbgoods_type.TabIndex = 50;
            // 
            // cbgoods_supplie
            // 
            this.cbgoods_supplie.FormattingEnabled = true;
            this.cbgoods_supplie.Location = new System.Drawing.Point(453, 121);
            this.cbgoods_supplie.Name = "cbgoods_supplie";
            this.cbgoods_supplie.Size = new System.Drawing.Size(149, 20);
            this.cbgoods_supplie.TabIndex = 51;
            // 
            // AD_addGood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 323);
            this.Controls.Add(this.cbgoods_supplie);
            this.Controls.Add(this.cbgoods_type);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbgoods_note);
            this.Controls.Add(this.tbgoods_inventory);
            this.Controls.Add(this.tbgoods_expirationDate);
            this.Controls.Add(this.tbgoods_productionDate);
            this.Controls.Add(this.tbgoods_purchasingCost);
            this.Controls.Add(this.tbgoods_retailPrice);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.tbgoods_units);
            this.Controls.Add(this.tbgoods_name);
            this.Controls.Add(this.tbgoods_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AD_addGood";
            this.Text = "添加商品";
            this.Load += new System.EventHandler(this.AD_addGood_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.TextBox tbgoods_units;
        private System.Windows.Forms.TextBox tbgoods_name;
        private System.Windows.Forms.TextBox tbgoods_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbgoods_retailPrice;
        private System.Windows.Forms.TextBox tbgoods_purchasingCost;
        private System.Windows.Forms.TextBox tbgoods_productionDate;
        private System.Windows.Forms.TextBox tbgoods_expirationDate;
        private System.Windows.Forms.TextBox tbgoods_inventory;
        private System.Windows.Forms.TextBox tbgoods_note;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbgoods_type;
        private System.Windows.Forms.ComboBox cbgoods_supplie;
    }
}
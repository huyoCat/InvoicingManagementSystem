namespace InvoicingManagementSystem
{
    partial class WH_PurchasingOrder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboBoxKeyword = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btSearch = new System.Windows.Forms.Button();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.dataGridView_OrderList = new System.Windows.Forms.DataGridView();
            this.bt_putOut = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.lbGoods_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_goods_name = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbGoods_ShowDate = new System.Windows.Forms.TextBox();
            this.tbNote = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbgoods_retailPrice = new System.Windows.Forms.TextBox();
            this.tbgoods_productionDate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbgoods_expirationDate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ColCheck = new System.Windows.Forms.DataGridViewLinkColumn();
            this.order_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_units = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_purchasingCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_purNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_SubmitDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_ShowDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_inventoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PutIn_inventoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_OrderList)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxKeyword
            // 
            this.comboBoxKeyword.FormattingEnabled = true;
            this.comboBoxKeyword.Location = new System.Drawing.Point(95, 18);
            this.comboBoxKeyword.Name = "comboBoxKeyword";
            this.comboBoxKeyword.Size = new System.Drawing.Size(97, 20);
            this.comboBoxKeyword.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 19;
            this.label1.Text = "选择查询方式";
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(415, 17);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(56, 21);
            this.btSearch.TabIndex = 18;
            this.btSearch.Text = "搜索";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(212, 18);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(179, 21);
            this.textBox_search.TabIndex = 17;
            // 
            // dataGridView_OrderList
            // 
            this.dataGridView_OrderList.AllowUserToAddRows = false;
            this.dataGridView_OrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_OrderList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCheck,
            this.order_count,
            this.goods_id,
            this.goods_name,
            this.goods_type,
            this.goods_units,
            this.goods_purchasingCost,
            this.goods_supplier,
            this.goods_purNumber,
            this.goods_SubmitDate,
            this.goods_ShowDate,
            this.order_inventoryID,
            this.PutIn_inventoryID,
            this.goods_note});
            this.dataGridView_OrderList.Location = new System.Drawing.Point(12, 45);
            this.dataGridView_OrderList.Name = "dataGridView_OrderList";
            this.dataGridView_OrderList.RowTemplate.Height = 23;
            this.dataGridView_OrderList.Size = new System.Drawing.Size(1295, 245);
            this.dataGridView_OrderList.TabIndex = 21;
            this.dataGridView_OrderList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_OrderList_CellContentClick);
            // 
            // bt_putOut
            // 
            this.bt_putOut.Location = new System.Drawing.Point(83, 400);
            this.bt_putOut.Name = "bt_putOut";
            this.bt_putOut.Size = new System.Drawing.Size(74, 22);
            this.bt_putOut.TabIndex = 22;
            this.bt_putOut.Text = "上架";
            this.bt_putOut.UseVisualStyleBackColor = true;
            this.bt_putOut.Click += new System.EventHandler(this.bt_putOut_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.Location = new System.Drawing.Point(250, 400);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(74, 22);
            this.bt_delete.TabIndex = 23;
            this.bt_delete.Text = "删除";
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // lbGoods_id
            // 
            this.lbGoods_id.Location = new System.Drawing.Point(131, 323);
            this.lbGoods_id.Name = "lbGoods_id";
            this.lbGoods_id.Size = new System.Drawing.Size(61, 21);
            this.lbGoods_id.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 12);
            this.label2.TabIndex = 25;
            this.label2.Text = "输入新的商品编号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 26;
            this.label3.Text = "商品名称：";
            // 
            // lb_goods_name
            // 
            this.lb_goods_name.AutoSize = true;
            this.lb_goods_name.Location = new System.Drawing.Point(274, 326);
            this.lb_goods_name.Name = "lb_goods_name";
            this.lb_goods_name.Size = new System.Drawing.Size(0, 12);
            this.lb_goods_name.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(465, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 28;
            this.label5.Text = "上架日期：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(678, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 29;
            this.label6.Text = "备注：";
            // 
            // tbGoods_ShowDate
            // 
            this.tbGoods_ShowDate.Location = new System.Drawing.Point(536, 323);
            this.tbGoods_ShowDate.Name = "tbGoods_ShowDate";
            this.tbGoods_ShowDate.Size = new System.Drawing.Size(136, 21);
            this.tbGoods_ShowDate.TabIndex = 30;
            // 
            // tbNote
            // 
            this.tbNote.Location = new System.Drawing.Point(725, 323);
            this.tbNote.Name = "tbNote";
            this.tbNote.Size = new System.Drawing.Size(249, 21);
            this.tbNote.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 368);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 33;
            this.label4.Text = "零售价：";
            // 
            // tbgoods_retailPrice
            // 
            this.tbgoods_retailPrice.Location = new System.Drawing.Point(83, 365);
            this.tbgoods_retailPrice.Name = "tbgoods_retailPrice";
            this.tbgoods_retailPrice.Size = new System.Drawing.Size(109, 21);
            this.tbgoods_retailPrice.TabIndex = 32;
            // 
            // tbgoods_productionDate
            // 
            this.tbgoods_productionDate.Location = new System.Drawing.Point(281, 365);
            this.tbgoods_productionDate.Name = "tbgoods_productionDate";
            this.tbgoods_productionDate.Size = new System.Drawing.Size(136, 21);
            this.tbgoods_productionDate.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(210, 368);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 34;
            this.label7.Text = "生产日期：";
            // 
            // tbgoods_expirationDate
            // 
            this.tbgoods_expirationDate.Location = new System.Drawing.Point(536, 368);
            this.tbgoods_expirationDate.Name = "tbgoods_expirationDate";
            this.tbgoods_expirationDate.Size = new System.Drawing.Size(136, 21);
            this.tbgoods_expirationDate.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(465, 371);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 36;
            this.label8.Text = "保质期：";
            // 
            // ColCheck
            // 
            dataGridViewCellStyle1.NullValue = "选择";
            this.ColCheck.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColCheck.HeaderText = "选择";
            this.ColCheck.Name = "ColCheck";
            this.ColCheck.Width = 50;
            // 
            // order_count
            // 
            this.order_count.DataPropertyName = "order_count";
            this.order_count.HeaderText = "订单序号";
            this.order_count.Name = "order_count";
            this.order_count.ReadOnly = true;
            this.order_count.Width = 50;
            // 
            // goods_id
            // 
            this.goods_id.DataPropertyName = "goods_id";
            this.goods_id.HeaderText = "商品编号";
            this.goods_id.Name = "goods_id";
            this.goods_id.ReadOnly = true;
            // 
            // goods_name
            // 
            this.goods_name.DataPropertyName = "goods_name";
            this.goods_name.HeaderText = "商品名称";
            this.goods_name.Name = "goods_name";
            this.goods_name.ReadOnly = true;
            // 
            // goods_type
            // 
            this.goods_type.DataPropertyName = "goods_type";
            this.goods_type.HeaderText = "商品种类";
            this.goods_type.Name = "goods_type";
            this.goods_type.ReadOnly = true;
            // 
            // goods_units
            // 
            this.goods_units.DataPropertyName = "goods_units";
            this.goods_units.HeaderText = "商品单位";
            this.goods_units.Name = "goods_units";
            this.goods_units.ReadOnly = true;
            // 
            // goods_purchasingCost
            // 
            this.goods_purchasingCost.DataPropertyName = "goods_purchasingCost";
            this.goods_purchasingCost.HeaderText = "进货价";
            this.goods_purchasingCost.Name = "goods_purchasingCost";
            this.goods_purchasingCost.ReadOnly = true;
            // 
            // goods_supplier
            // 
            this.goods_supplier.DataPropertyName = "goods_supplier";
            this.goods_supplier.HeaderText = "供应商";
            this.goods_supplier.Name = "goods_supplier";
            this.goods_supplier.ReadOnly = true;
            // 
            // goods_purNumber
            // 
            this.goods_purNumber.DataPropertyName = "goods_purNumber";
            this.goods_purNumber.HeaderText = "订购数量";
            this.goods_purNumber.Name = "goods_purNumber";
            this.goods_purNumber.ReadOnly = true;
            // 
            // goods_SubmitDate
            // 
            this.goods_SubmitDate.DataPropertyName = "goods_SubmitDate";
            this.goods_SubmitDate.HeaderText = "提交日期";
            this.goods_SubmitDate.Name = "goods_SubmitDate";
            this.goods_SubmitDate.ReadOnly = true;
            // 
            // goods_ShowDate
            // 
            this.goods_ShowDate.DataPropertyName = "goods_ShowDate";
            this.goods_ShowDate.HeaderText = "上架日期";
            this.goods_ShowDate.Name = "goods_ShowDate";
            this.goods_ShowDate.ReadOnly = true;
            // 
            // order_inventoryID
            // 
            this.order_inventoryID.DataPropertyName = "order_inventoryID";
            this.order_inventoryID.HeaderText = "下单库员";
            this.order_inventoryID.Name = "order_inventoryID";
            this.order_inventoryID.ReadOnly = true;
            // 
            // PutIn_inventoryID
            // 
            this.PutIn_inventoryID.DataPropertyName = "PutIn_inventoryID";
            this.PutIn_inventoryID.HeaderText = "上架库员";
            this.PutIn_inventoryID.Name = "PutIn_inventoryID";
            this.PutIn_inventoryID.ReadOnly = true;
            // 
            // goods_note
            // 
            this.goods_note.DataPropertyName = "goods_note";
            this.goods_note.HeaderText = "备注";
            this.goods_note.Name = "goods_note";
            this.goods_note.ReadOnly = true;
            // 
            // WH_PurchasingOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 434);
            this.Controls.Add(this.tbgoods_expirationDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbgoods_productionDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbgoods_retailPrice);
            this.Controls.Add(this.tbNote);
            this.Controls.Add(this.tbGoods_ShowDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lb_goods_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbGoods_id);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.bt_putOut);
            this.Controls.Add(this.dataGridView_OrderList);
            this.Controls.Add(this.comboBoxKeyword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.textBox_search);
            this.Name = "WH_PurchasingOrder";
            this.Text = "进货订单";
            this.Load += new System.EventHandler(this.WH_PurchasingOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_OrderList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxKeyword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.DataGridView dataGridView_OrderList;
        private System.Windows.Forms.Button bt_putOut;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.TextBox lbGoods_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_goods_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbGoods_ShowDate;
        private System.Windows.Forms.TextBox tbNote;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbgoods_retailPrice;
        private System.Windows.Forms.TextBox tbgoods_productionDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbgoods_expirationDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewLinkColumn ColCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_count;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_units;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_purchasingCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_purNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_SubmitDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_ShowDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_inventoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PutIn_inventoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_note;
    }
}
namespace InvoicingManagementSystem
{
    partial class WH_SelectInventory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView_SelectInventory = new System.Windows.Forms.DataGridView();
            this.ColCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.goods_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_units = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_purchasingCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_productionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_expirationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_inventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxKeyword = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btSearch = new System.Windows.Forms.Button();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.btADD = new System.Windows.Forms.Button();
            this.dataGridView_order = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_submit = new System.Windows.Forms.Button();
            this.bt_removeGood = new System.Windows.Forms.Button();
            this.CHECK = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_purNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SelectInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_order)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_SelectInventory
            // 
            this.dataGridView_SelectInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_SelectInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCheck,
            this.goods_id,
            this.goods_name,
            this.goods_type,
            this.goods_units,
            this.goods_purchasingCost,
            this.goods_productionDate,
            this.goods_expirationDate,
            this.goods_supplier,
            this.goods_inventory});
            this.dataGridView_SelectInventory.Location = new System.Drawing.Point(12, 41);
            this.dataGridView_SelectInventory.Name = "dataGridView_SelectInventory";
            this.dataGridView_SelectInventory.RowTemplate.Height = 23;
            this.dataGridView_SelectInventory.Size = new System.Drawing.Size(997, 295);
            this.dataGridView_SelectInventory.TabIndex = 0;
            // 
            // ColCheck
            // 
            this.ColCheck.HeaderText = "选择";
            this.ColCheck.Name = "ColCheck";
            this.ColCheck.Width = 50;
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
            this.goods_type.HeaderText = "商品类型";
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
            this.goods_purchasingCost.HeaderText = "商品进价";
            this.goods_purchasingCost.Name = "goods_purchasingCost";
            this.goods_purchasingCost.ReadOnly = true;
            // 
            // goods_productionDate
            // 
            this.goods_productionDate.DataPropertyName = "goods_productionDate";
            this.goods_productionDate.HeaderText = "生产日期";
            this.goods_productionDate.Name = "goods_productionDate";
            this.goods_productionDate.ReadOnly = true;
            // 
            // goods_expirationDate
            // 
            this.goods_expirationDate.DataPropertyName = "goods_expirationDate";
            this.goods_expirationDate.HeaderText = "保质期限";
            this.goods_expirationDate.Name = "goods_expirationDate";
            this.goods_expirationDate.ReadOnly = true;
            // 
            // goods_supplier
            // 
            this.goods_supplier.DataPropertyName = "goods_supplier";
            this.goods_supplier.HeaderText = "供应商";
            this.goods_supplier.Name = "goods_supplier";
            this.goods_supplier.ReadOnly = true;
            // 
            // goods_inventory
            // 
            this.goods_inventory.DataPropertyName = "goods_inventory";
            this.goods_inventory.HeaderText = "库存数量";
            this.goods_inventory.Name = "goods_inventory";
            this.goods_inventory.ReadOnly = true;
            // 
            // comboBoxKeyword
            // 
            this.comboBoxKeyword.FormattingEnabled = true;
            this.comboBoxKeyword.Location = new System.Drawing.Point(101, 12);
            this.comboBoxKeyword.Name = "comboBoxKeyword";
            this.comboBoxKeyword.Size = new System.Drawing.Size(97, 20);
            this.comboBoxKeyword.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "选择查询方式";
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(357, 12);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(56, 21);
            this.btSearch.TabIndex = 12;
            this.btSearch.Text = "搜索";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(204, 12);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(137, 21);
            this.textBox_search.TabIndex = 11;
            // 
            // btADD
            // 
            this.btADD.Location = new System.Drawing.Point(525, 11);
            this.btADD.Name = "btADD";
            this.btADD.Size = new System.Drawing.Size(75, 23);
            this.btADD.TabIndex = 15;
            this.btADD.Text = "订购商品";
            this.btADD.UseVisualStyleBackColor = true;
            this.btADD.Click += new System.EventHandler(this.btADD_Click);
            // 
            // dataGridView_order
            // 
            this.dataGridView_order.AllowUserToAddRows = false;
            this.dataGridView_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_order.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CHECK,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn8,
            this.inventory,
            this.goods_purNumber});
            this.dataGridView_order.Location = new System.Drawing.Point(12, 387);
            this.dataGridView_order.Name = "dataGridView_order";
            this.dataGridView_order.RowTemplate.Height = 23;
            this.dataGridView_order.Size = new System.Drawing.Size(894, 212);
            this.dataGridView_order.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 17;
            this.label2.Text = "进货单：";
            // 
            // bt_delete
            // 
            this.bt_delete.Location = new System.Drawing.Point(927, 443);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(75, 23);
            this.bt_delete.TabIndex = 18;
            this.bt_delete.Text = "移除选择";
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // bt_submit
            // 
            this.bt_submit.Location = new System.Drawing.Point(927, 522);
            this.bt_submit.Name = "bt_submit";
            this.bt_submit.Size = new System.Drawing.Size(75, 23);
            this.bt_submit.TabIndex = 19;
            this.bt_submit.Text = "提交订单";
            this.bt_submit.UseVisualStyleBackColor = true;
            this.bt_submit.Click += new System.EventHandler(this.bt_submit_Click);
            // 
            // bt_removeGood
            // 
            this.bt_removeGood.Location = new System.Drawing.Point(658, 12);
            this.bt_removeGood.Name = "bt_removeGood";
            this.bt_removeGood.Size = new System.Drawing.Size(75, 23);
            this.bt_removeGood.TabIndex = 20;
            this.bt_removeGood.Text = "下架";
            this.bt_removeGood.UseVisualStyleBackColor = true;
            this.bt_removeGood.Click += new System.EventHandler(this.bt_removeGood_Click);
            // 
            // CHECK
            // 
            this.CHECK.HeaderText = "选择";
            this.CHECK.Name = "CHECK";
            this.CHECK.Width = 50;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "goods_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "商品编号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "goods_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "商品名称";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "goods_type";
            this.dataGridViewTextBoxColumn3.HeaderText = "商品类型";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "goods_units";
            this.dataGridViewTextBoxColumn4.HeaderText = "商品单位";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "goods_purchasingCost";
            this.dataGridViewTextBoxColumn5.HeaderText = "商品进价";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "goods_supplier";
            this.dataGridViewTextBoxColumn8.HeaderText = "供应商";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // inventory
            // 
            this.inventory.DataPropertyName = "goods_inventory";
            this.inventory.HeaderText = "现有库存";
            this.inventory.Name = "inventory";
            this.inventory.ReadOnly = true;
            // 
            // goods_purNumber
            // 
            this.goods_purNumber.DataPropertyName = "goods_purNumber";
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = "1";
            this.goods_purNumber.DefaultCellStyle = dataGridViewCellStyle2;
            this.goods_purNumber.HeaderText = "订购数量";
            this.goods_purNumber.Name = "goods_purNumber";
            // 
            // WH_SelectInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 611);
            this.Controls.Add(this.bt_removeGood);
            this.Controls.Add(this.bt_submit);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView_order);
            this.Controls.Add(this.btADD);
            this.Controls.Add(this.comboBoxKeyword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.dataGridView_SelectInventory);
            this.Name = "WH_SelectInventory";
            this.Text = "库存查询";
            this.Load += new System.EventHandler(this.WH_SelectInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SelectInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_order)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_SelectInventory;
        private System.Windows.Forms.ComboBox comboBoxKeyword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Button btADD;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_units;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_purchasingCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_productionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_expirationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_inventory;
        private System.Windows.Forms.DataGridView dataGridView_order;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.Button bt_submit;
        private System.Windows.Forms.Button bt_removeGood;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CHECK;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_purNumber;
    }
}
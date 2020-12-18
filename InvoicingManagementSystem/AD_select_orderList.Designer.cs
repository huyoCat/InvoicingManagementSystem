namespace InvoicingManagementSystem
{
    partial class AD_select_orderList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView_order = new System.Windows.Forms.DataGridView();
            this.comboBoxKeyword = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btSearch = new System.Windows.Forms.Button();
            this.textBox_search = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_order)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_order
            // 
            this.dataGridView_order.AllowUserToAddRows = false;
            this.dataGridView_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_order.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridView_order.Location = new System.Drawing.Point(12, 42);
            this.dataGridView_order.Name = "dataGridView_order";
            this.dataGridView_order.RowTemplate.Height = 23;
            this.dataGridView_order.Size = new System.Drawing.Size(697, 349);
            this.dataGridView_order.TabIndex = 17;
            // 
            // comboBoxKeyword
            // 
            this.comboBoxKeyword.FormattingEnabled = true;
            this.comboBoxKeyword.Location = new System.Drawing.Point(95, 5);
            this.comboBoxKeyword.Name = "comboBoxKeyword";
            this.comboBoxKeyword.Size = new System.Drawing.Size(97, 20);
            this.comboBoxKeyword.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 20;
            this.label1.Text = "选择查询方式";
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(351, 5);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(56, 21);
            this.btSearch.TabIndex = 19;
            this.btSearch.Text = "搜索";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(198, 5);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(137, 21);
            this.textBox_search.TabIndex = 18;
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
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = "1";
            this.goods_purNumber.DefaultCellStyle = dataGridViewCellStyle3;
            this.goods_purNumber.HeaderText = "订购数量";
            this.goods_purNumber.Name = "goods_purNumber";
            // 
            // goods_SubmitDate
            // 
            this.goods_SubmitDate.DataPropertyName = "goods_SubmitDate";
            this.goods_SubmitDate.HeaderText = "提交时间";
            this.goods_SubmitDate.Name = "goods_SubmitDate";
            this.goods_SubmitDate.ReadOnly = true;
            // 
            // goods_ShowDate
            // 
            this.goods_ShowDate.DataPropertyName = "goods_ShowDate";
            this.goods_ShowDate.HeaderText = "上架时间";
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
            // AD_select_orderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 403);
            this.Controls.Add(this.comboBoxKeyword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.dataGridView_order);
            this.Name = "AD_select_orderList";
            this.Text = "查询商品进购单";
            this.Load += new System.EventHandler(this.AD_select_orderList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_order)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_order;
        private System.Windows.Forms.ComboBox comboBoxKeyword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.TextBox textBox_search;
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
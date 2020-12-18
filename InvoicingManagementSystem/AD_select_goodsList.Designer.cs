namespace InvoicingManagementSystem
{
    partial class AD_select_goodsList
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
            this.label1 = new System.Windows.Forms.Label();
            this.btSearch = new System.Windows.Forms.Button();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.dataGridView_select_goodsList = new System.Windows.Forms.DataGridView();
            this.goods_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_units = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_purchasingCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_productionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_expirationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_inventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsDeleted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_select_goodsList)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxKeyword
            // 
            this.comboBoxKeyword.FormattingEnabled = true;
            this.comboBoxKeyword.Location = new System.Drawing.Point(95, 5);
            this.comboBoxKeyword.Name = "comboBoxKeyword";
            this.comboBoxKeyword.Size = new System.Drawing.Size(97, 20);
            this.comboBoxKeyword.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 24;
            this.label1.Text = "选择查询方式";
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(351, 5);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(56, 21);
            this.btSearch.TabIndex = 23;
            this.btSearch.Text = "搜索";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(198, 5);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(137, 21);
            this.textBox_search.TabIndex = 22;
            // 
            // dataGridView_select_goodsList
            // 
            this.dataGridView_select_goodsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_select_goodsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.goods_id,
            this.goods_name,
            this.goods_type,
            this.goods_units,
            this.goods_purchasingCost,
            this.goods_productionDate,
            this.goods_expirationDate,
            this.goods_supplier,
            this.goods_inventory,
            this.IsDeleted,
            this.goods_note});
            this.dataGridView_select_goodsList.Location = new System.Drawing.Point(6, 34);
            this.dataGridView_select_goodsList.Name = "dataGridView_select_goodsList";
            this.dataGridView_select_goodsList.RowTemplate.Height = 23;
            this.dataGridView_select_goodsList.Size = new System.Drawing.Size(783, 329);
            this.dataGridView_select_goodsList.TabIndex = 21;
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
            // IsDeleted
            // 
            this.IsDeleted.DataPropertyName = "IsDeleted";
            this.IsDeleted.HeaderText = "是否在售";
            this.IsDeleted.Name = "IsDeleted";
            this.IsDeleted.ReadOnly = true;
            // 
            // goods_note
            // 
            this.goods_note.DataPropertyName = "goods_note";
            this.goods_note.HeaderText = "备注";
            this.goods_note.Name = "goods_note";
            this.goods_note.ReadOnly = true;
            // 
            // AD_select_goodsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 375);
            this.Controls.Add(this.comboBoxKeyword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.dataGridView_select_goodsList);
            this.Name = "AD_select_goodsList";
            this.Text = "查询商品";
            this.Load += new System.EventHandler(this.AD_select_goodsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_select_goodsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxKeyword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.DataGridView dataGridView_select_goodsList;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_units;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_purchasingCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_productionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_expirationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_inventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsDeleted;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_note;
    }
}
﻿namespace InvoicingManagementSystem
{
    partial class CA_history
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
            this.dataGridView_SalesList = new System.Windows.Forms.DataGridView();
            this.goods_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_units = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_retailPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_soldDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_salespersonID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btSearch = new System.Windows.Forms.Button();
            this.textBox_search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SalesList)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxKeyword
            // 
            this.comboBoxKeyword.FormattingEnabled = true;
            this.comboBoxKeyword.Location = new System.Drawing.Point(110, 12);
            this.comboBoxKeyword.Name = "comboBoxKeyword";
            this.comboBoxKeyword.Size = new System.Drawing.Size(97, 20);
            this.comboBoxKeyword.TabIndex = 16;
            // 
            // dataGridView_SalesList
            // 
            this.dataGridView_SalesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_SalesList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.goods_id,
            this.goods_name,
            this.goods_type,
            this.goods_number,
            this.goods_units,
            this.goods_retailPrice,
            this.goods_soldDate,
            this.goods_salespersonID});
            this.dataGridView_SalesList.Location = new System.Drawing.Point(12, 54);
            this.dataGridView_SalesList.Name = "dataGridView_SalesList";
            this.dataGridView_SalesList.RowTemplate.Height = 23;
            this.dataGridView_SalesList.Size = new System.Drawing.Size(848, 358);
            this.dataGridView_SalesList.TabIndex = 15;
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
            // goods_number
            // 
            this.goods_number.DataPropertyName = "goods_number";
            this.goods_number.HeaderText = "购买数量";
            this.goods_number.Name = "goods_number";
            this.goods_number.ReadOnly = true;
            // 
            // goods_units
            // 
            this.goods_units.DataPropertyName = "goods_units";
            this.goods_units.HeaderText = "商品单位";
            this.goods_units.Name = "goods_units";
            this.goods_units.ReadOnly = true;
            // 
            // goods_retailPrice
            // 
            this.goods_retailPrice.DataPropertyName = "goods_retailPrice";
            this.goods_retailPrice.HeaderText = "零售价";
            this.goods_retailPrice.Name = "goods_retailPrice";
            this.goods_retailPrice.ReadOnly = true;
            // 
            // goods_soldDate
            // 
            this.goods_soldDate.DataPropertyName = "goods_soldDate";
            this.goods_soldDate.HeaderText = "销售日期";
            this.goods_soldDate.Name = "goods_soldDate";
            this.goods_soldDate.ReadOnly = true;
            // 
            // goods_salespersonID
            // 
            this.goods_salespersonID.DataPropertyName = "goods_salespersonID";
            this.goods_salespersonID.HeaderText = "销售员";
            this.goods_salespersonID.Name = "goods_salespersonID";
            this.goods_salespersonID.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "选择查询方式";
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(430, 11);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(56, 21);
            this.btSearch.TabIndex = 13;
            this.btSearch.Text = "搜索";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(227, 12);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(179, 21);
            this.textBox_search.TabIndex = 12;
            // 
            // CA_history
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 424);
            this.Controls.Add(this.comboBoxKeyword);
            this.Controls.Add(this.dataGridView_SalesList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.textBox_search);
            this.Name = "CA_history";
            this.Text = "查询历史交易";
            this.Load += new System.EventHandler(this.CA_history_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SalesList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxKeyword;
        private System.Windows.Forms.DataGridView dataGridView_SalesList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_units;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_retailPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_soldDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_salespersonID;
    }
}
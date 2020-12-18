namespace InvoicingManagementSystem
{
    partial class AD_select_GoodsSort
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
            this.dataGridView_GoodsTypeList = new System.Windows.Forms.DataGridView();
            this.ColChecked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btSearch = new System.Windows.Forms.Button();
            this.textBox_search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_GoodsTypeList)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxKeyword
            // 
            this.comboBoxKeyword.FormattingEnabled = true;
            this.comboBoxKeyword.Location = new System.Drawing.Point(95, 5);
            this.comboBoxKeyword.Name = "comboBoxKeyword";
            this.comboBoxKeyword.Size = new System.Drawing.Size(82, 20);
            this.comboBoxKeyword.TabIndex = 21;
            // 
            // dataGridView_GoodsTypeList
            // 
            this.dataGridView_GoodsTypeList.AllowUserToAddRows = false;
            this.dataGridView_GoodsTypeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_GoodsTypeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColChecked,
            this.id,
            this.name});
            this.dataGridView_GoodsTypeList.Location = new System.Drawing.Point(33, 51);
            this.dataGridView_GoodsTypeList.Name = "dataGridView_GoodsTypeList";
            this.dataGridView_GoodsTypeList.RowTemplate.Height = 23;
            this.dataGridView_GoodsTypeList.Size = new System.Drawing.Size(297, 299);
            this.dataGridView_GoodsTypeList.TabIndex = 20;
            // 
            // ColChecked
            // 
            this.ColChecked.HeaderText = "选择";
            this.ColChecked.Name = "ColChecked";
            this.ColChecked.Width = 50;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "商品种类编号";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "商品种类名称";
            this.name.Name = "name";
            this.name.ReadOnly = true;
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
            this.btSearch.Location = new System.Drawing.Point(316, 5);
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
            this.textBox_search.Size = new System.Drawing.Size(95, 21);
            this.textBox_search.TabIndex = 17;
            // 
            // AD_select_GoodsSort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 362);
            this.Controls.Add(this.comboBoxKeyword);
            this.Controls.Add(this.dataGridView_GoodsTypeList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.textBox_search);
            this.Name = "AD_select_GoodsSort";
            this.Text = "查询商品种类";
            this.Load += new System.EventHandler(this.AD_select_GoodsSort_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_GoodsTypeList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxKeyword;
        private System.Windows.Forms.DataGridView dataGridView_GoodsTypeList;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColChecked;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.TextBox textBox_search;
    }
}
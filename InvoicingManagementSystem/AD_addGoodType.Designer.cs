namespace InvoicingManagementSystem
{
    partial class AD_addGoodType
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
            this.btADD = new System.Windows.Forms.Button();
            this.comboBoxKeyword = new System.Windows.Forms.ComboBox();
            this.dataGridView_GoodsTypeList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btSearch = new System.Windows.Forms.Button();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.ColChecked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Sort_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sort_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_typeID = new System.Windows.Forms.TextBox();
            this.tb_typeName = new System.Windows.Forms.TextBox();
            this.btDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_GoodsTypeList)).BeginInit();
            this.SuspendLayout();
            // 
            // btADD
            // 
            this.btADD.Location = new System.Drawing.Point(398, 178);
            this.btADD.Name = "btADD";
            this.btADD.Size = new System.Drawing.Size(103, 23);
            this.btADD.TabIndex = 17;
            this.btADD.Text = "添加商品种类";
            this.btADD.UseVisualStyleBackColor = true;
            this.btADD.Click += new System.EventHandler(this.btADD_Click);
            // 
            // comboBoxKeyword
            // 
            this.comboBoxKeyword.FormattingEnabled = true;
            this.comboBoxKeyword.Location = new System.Drawing.Point(86, 12);
            this.comboBoxKeyword.Name = "comboBoxKeyword";
            this.comboBoxKeyword.Size = new System.Drawing.Size(97, 20);
            this.comboBoxKeyword.TabIndex = 16;
            // 
            // dataGridView_GoodsTypeList
            // 
            this.dataGridView_GoodsTypeList.AllowUserToAddRows = false;
            this.dataGridView_GoodsTypeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_GoodsTypeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColChecked,
            this.Sort_id,
            this.Sort_name});
            this.dataGridView_GoodsTypeList.Location = new System.Drawing.Point(12, 49);
            this.dataGridView_GoodsTypeList.Name = "dataGridView_GoodsTypeList";
            this.dataGridView_GoodsTypeList.RowTemplate.Height = 23;
            this.dataGridView_GoodsTypeList.Size = new System.Drawing.Size(297, 299);
            this.dataGridView_GoodsTypeList.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "选择查询方式";
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(342, 12);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(56, 21);
            this.btSearch.TabIndex = 13;
            this.btSearch.Text = "搜索";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(189, 12);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(137, 21);
            this.textBox_search.TabIndex = 12;
            // 
            // ColChecked
            // 
            this.ColChecked.HeaderText = "选择";
            this.ColChecked.Name = "ColChecked";
            this.ColChecked.Width = 50;
            // 
            // Sort_id
            // 
            this.Sort_id.DataPropertyName = "Sort_id";
            this.Sort_id.HeaderText = "商品种类编号";
            this.Sort_id.Name = "Sort_id";
            this.Sort_id.ReadOnly = true;
            // 
            // Sort_name
            // 
            this.Sort_name.DataPropertyName = "Sort_name";
            this.Sort_name.HeaderText = "商品种类名称";
            this.Sort_name.Name = "Sort_name";
            this.Sort_name.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(373, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 18;
            this.label2.Text = "输入编号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(373, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 19;
            this.label3.Text = "输入名称：";
            // 
            // tb_typeID
            // 
            this.tb_typeID.Location = new System.Drawing.Point(464, 67);
            this.tb_typeID.Name = "tb_typeID";
            this.tb_typeID.Size = new System.Drawing.Size(100, 21);
            this.tb_typeID.TabIndex = 20;
            // 
            // tb_typeName
            // 
            this.tb_typeName.Location = new System.Drawing.Point(464, 121);
            this.tb_typeName.Name = "tb_typeName";
            this.tb_typeName.Size = new System.Drawing.Size(100, 21);
            this.tb_typeName.TabIndex = 21;
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(398, 261);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(103, 23);
            this.btDelete.TabIndex = 22;
            this.btDelete.Text = "删除所选种类";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // AD_addGoodType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 360);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.tb_typeName);
            this.Controls.Add(this.tb_typeID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btADD);
            this.Controls.Add(this.comboBoxKeyword);
            this.Controls.Add(this.dataGridView_GoodsTypeList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.textBox_search);
            this.Name = "AD_addGoodType";
            this.Text = "添加商品种类";
            this.Load += new System.EventHandler(this.AD_addGoodType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_GoodsTypeList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btADD;
        private System.Windows.Forms.ComboBox comboBoxKeyword;
        private System.Windows.Forms.DataGridView dataGridView_GoodsTypeList;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColChecked;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sort_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sort_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_typeID;
        private System.Windows.Forms.TextBox tb_typeName;
        private System.Windows.Forms.Button btDelete;
    }
}
namespace InvoicingManagementSystem
{
    partial class CA_checkOut
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
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.btSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_GoodsList = new System.Windows.Forms.DataGridView();
            this.ColChecked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.goods_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_units = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_retailPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_inventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView_SalesList = new System.Windows.Forms.DataGridView();
            this.btSubmit = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxKeyword = new System.Windows.Forms.ComboBox();
            this.btADD = new System.Windows.Forms.Button();
            this.lbCost = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ColOrderCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.units = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.retailPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_GoodsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SalesList)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(198, 18);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(137, 21);
            this.textBox_search.TabIndex = 0;
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(351, 18);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(56, 21);
            this.btSearch.TabIndex = 1;
            this.btSearch.Text = "搜索";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "选择查询方式";
            // 
            // dataGridView_GoodsList
            // 
            this.dataGridView_GoodsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_GoodsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColChecked,
            this.goods_id,
            this.goods_name,
            this.goods_type,
            this.goods_units,
            this.goods_retailPrice,
            this.goods_inventory});
            this.dataGridView_GoodsList.Location = new System.Drawing.Point(14, 59);
            this.dataGridView_GoodsList.Name = "dataGridView_GoodsList";
            this.dataGridView_GoodsList.RowTemplate.Height = 23;
            this.dataGridView_GoodsList.Size = new System.Drawing.Size(695, 358);
            this.dataGridView_GoodsList.TabIndex = 4;
            // 
            // ColChecked
            // 
            this.ColChecked.HeaderText = "选择";
            this.ColChecked.Name = "ColChecked";
            this.ColChecked.Width = 50;
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
            // goods_retailPrice
            // 
            this.goods_retailPrice.DataPropertyName = "goods_retailPrice";
            this.goods_retailPrice.HeaderText = "零售价";
            this.goods_retailPrice.Name = "goods_retailPrice";
            this.goods_retailPrice.ReadOnly = true;
            // 
            // goods_inventory
            // 
            this.goods_inventory.DataPropertyName = "goods_inventory";
            this.goods_inventory.HeaderText = "商品库存";
            this.goods_inventory.Name = "goods_inventory";
            this.goods_inventory.ReadOnly = true;
            // 
            // dataGridView_SalesList
            // 
            this.dataGridView_SalesList.AllowUserToAddRows = false;
            this.dataGridView_SalesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_SalesList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColOrderCheck,
            this.id,
            this.name,
            this.goods_number,
            this.inventory,
            this.units,
            this.retailPrice});
            this.dataGridView_SalesList.Location = new System.Drawing.Point(729, 59);
            this.dataGridView_SalesList.Name = "dataGridView_SalesList";
            this.dataGridView_SalesList.RowTemplate.Height = 23;
            this.dataGridView_SalesList.Size = new System.Drawing.Size(593, 285);
            this.dataGridView_SalesList.TabIndex = 5;
            this.dataGridView_SalesList.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_SalesList_CellEndEdit);
            // 
            // btSubmit
            // 
            this.btSubmit.Location = new System.Drawing.Point(1180, 374);
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.Size = new System.Drawing.Size(75, 23);
            this.btSubmit.TabIndex = 7;
            this.btSubmit.Text = "提交";
            this.btSubmit.UseVisualStyleBackColor = true;
            this.btSubmit.Click += new System.EventHandler(this.btSubmit_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(1053, 374);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 8;
            this.btDelete.Text = "删除选择";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(767, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "购买清单";
            // 
            // comboBoxKeyword
            // 
            this.comboBoxKeyword.FormattingEnabled = true;
            this.comboBoxKeyword.Location = new System.Drawing.Point(95, 18);
            this.comboBoxKeyword.Name = "comboBoxKeyword";
            this.comboBoxKeyword.Size = new System.Drawing.Size(97, 20);
            this.comboBoxKeyword.TabIndex = 10;
            // 
            // btADD
            // 
            this.btADD.Location = new System.Drawing.Point(555, 18);
            this.btADD.Name = "btADD";
            this.btADD.Size = new System.Drawing.Size(75, 23);
            this.btADD.TabIndex = 11;
            this.btADD.Text = "添加";
            this.btADD.UseVisualStyleBackColor = true;
            this.btADD.Click += new System.EventHandler(this.btADD_Click);
            // 
            // lbCost
            // 
            this.lbCost.AutoSize = true;
            this.lbCost.Location = new System.Drawing.Point(826, 374);
            this.lbCost.Name = "lbCost";
            this.lbCost.Size = new System.Drawing.Size(0, 12);
            this.lbCost.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(755, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "消费总额：";
            // 
            // ColOrderCheck
            // 
            this.ColOrderCheck.HeaderText = "选择";
            this.ColOrderCheck.Name = "ColOrderCheck";
            this.ColOrderCheck.Width = 50;
            // 
            // id
            // 
            this.id.DataPropertyName = "goods_id";
            this.id.HeaderText = "商品编号";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "goods_name";
            this.name.HeaderText = "名称";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // goods_number
            // 
            this.goods_number.DataPropertyName = "goods_number";
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = "1";
            this.goods_number.DefaultCellStyle = dataGridViewCellStyle1;
            this.goods_number.HeaderText = "购买数量";
            this.goods_number.Name = "goods_number";
            this.goods_number.Width = 80;
            // 
            // inventory
            // 
            this.inventory.DataPropertyName = "goods_inventory";
            this.inventory.HeaderText = "商品库存";
            this.inventory.Name = "inventory";
            this.inventory.ReadOnly = true;
            this.inventory.Width = 80;
            // 
            // units
            // 
            this.units.DataPropertyName = "goods_units";
            this.units.HeaderText = "单位";
            this.units.Name = "units";
            this.units.ReadOnly = true;
            this.units.Width = 60;
            // 
            // retailPrice
            // 
            this.retailPrice.DataPropertyName = "goods_retailPrice";
            this.retailPrice.HeaderText = "零售价";
            this.retailPrice.Name = "retailPrice";
            this.retailPrice.ReadOnly = true;
            // 
            // CA_checkOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1337, 429);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbCost);
            this.Controls.Add(this.btADD);
            this.Controls.Add(this.comboBoxKeyword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btSubmit);
            this.Controls.Add(this.dataGridView_SalesList);
            this.Controls.Add(this.dataGridView_GoodsList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.textBox_search);
            this.Name = "CA_checkOut";
            this.Text = "办理结账";
            this.Load += new System.EventHandler(this.CA_checkOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_GoodsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SalesList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Button btSearch;
        //private System.Windows.Forms.ComboBox comboBox_keyword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_GoodsList;
        private System.Windows.Forms.DataGridView dataGridView_SalesList;
        private System.Windows.Forms.Button btSubmit;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxKeyword;
        private System.Windows.Forms.Button btADD;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColChecked;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_units;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_retailPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_inventory;
        private System.Windows.Forms.Label lbCost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColOrderCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn units;
        private System.Windows.Forms.DataGridViewTextBoxColumn retailPrice;
    }
}
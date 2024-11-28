namespace SupermarketObrabotka
{
    partial class Form5
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
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.superMarketDataSet = new SupermarketObrabotka.SuperMarketDataSet();
            this.superMarketDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supermarketTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supermarketTableTableAdapter = new SupermarketObrabotka.SuperMarketDataSetTableAdapters.SupermarketTableTableAdapter();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.haveInMarketDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.haveInInventoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.superMarketDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.superMarketDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supermarketTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 36;
            this.listBox1.Location = new System.Drawing.Point(36, 105);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(213, 472);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F);
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 36;
            this.listBox2.Location = new System.Drawing.Point(289, 105);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(135, 472);
            this.listBox2.TabIndex = 1;
            // 
            // listBox3
            // 
            this.listBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F);
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 36;
            this.listBox3.Location = new System.Drawing.Point(462, 105);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(231, 472);
            this.listBox3.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.productPriceDataGridViewTextBoxColumn,
            this.haveInMarketDataGridViewTextBoxColumn,
            this.haveInInventoryDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.supermarketTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(926, 660);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(10, 15);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.Visible = false;
            // 
            // superMarketDataSet
            // 
            this.superMarketDataSet.DataSetName = "SuperMarketDataSet";
            this.superMarketDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // superMarketDataSetBindingSource
            // 
            this.superMarketDataSetBindingSource.DataSource = this.superMarketDataSet;
            this.superMarketDataSetBindingSource.Position = 0;
            // 
            // supermarketTableBindingSource
            // 
            this.supermarketTableBindingSource.DataMember = "SupermarketTable";
            this.supermarketTableBindingSource.DataSource = this.superMarketDataSetBindingSource;
            // 
            // supermarketTableTableAdapter
            // 
            this.supermarketTableTableAdapter.ClearBeforeFill = true;
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            this.кодDataGridViewTextBoxColumn.Width = 125;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // productPriceDataGridViewTextBoxColumn
            // 
            this.productPriceDataGridViewTextBoxColumn.DataPropertyName = "ProductPrice";
            this.productPriceDataGridViewTextBoxColumn.HeaderText = "ProductPrice";
            this.productPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productPriceDataGridViewTextBoxColumn.Name = "productPriceDataGridViewTextBoxColumn";
            this.productPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // haveInMarketDataGridViewTextBoxColumn
            // 
            this.haveInMarketDataGridViewTextBoxColumn.DataPropertyName = "HaveInMarket";
            this.haveInMarketDataGridViewTextBoxColumn.HeaderText = "HaveInMarket";
            this.haveInMarketDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.haveInMarketDataGridViewTextBoxColumn.Name = "haveInMarketDataGridViewTextBoxColumn";
            this.haveInMarketDataGridViewTextBoxColumn.Width = 125;
            // 
            // haveInInventoryDataGridViewTextBoxColumn
            // 
            this.haveInInventoryDataGridViewTextBoxColumn.DataPropertyName = "HaveInInventory";
            this.haveInInventoryDataGridViewTextBoxColumn.HeaderText = "HaveInInventory";
            this.haveInInventoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.haveInInventoryDataGridViewTextBoxColumn.Name = "haveInInventoryDataGridViewTextBoxColumn";
            this.haveInInventoryDataGridViewTextBoxColumn.Width = 125;
            // 
            // listBox4
            // 
            this.listBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F);
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 36;
            this.listBox4.Location = new System.Drawing.Point(730, 105);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(247, 472);
            this.listBox4.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F);
            this.label1.Location = new System.Drawing.Point(2, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "Название товара";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F);
            this.label2.Location = new System.Drawing.Point(292, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 36);
            this.label2.TabIndex = 6;
            this.label2.Text = "Цена";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F);
            this.label3.Location = new System.Drawing.Point(456, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 72);
            this.label3.TabIndex = 7;
            this.label3.Text = "Наличие в\r\n супермакете";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F);
            this.label4.Location = new System.Drawing.Point(724, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 72);
            this.label4.TabIndex = 8;
            this.label4.Text = "Наличие на\r\n складе\r\n";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 709);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form5_FormClosing);
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.superMarketDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.superMarketDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supermarketTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource superMarketDataSetBindingSource;
        private SuperMarketDataSet superMarketDataSet;
        private System.Windows.Forms.BindingSource supermarketTableBindingSource;
        private SuperMarketDataSetTableAdapters.SupermarketTableTableAdapter supermarketTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn haveInMarketDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn haveInInventoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
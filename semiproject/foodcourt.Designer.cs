namespace semiproject
{
    partial class Main
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
            this.CARDBT = new System.Windows.Forms.Button();
            this.CASHBT = new System.Windows.Forms.Button();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.menu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DELETEBT = new System.Windows.Forms.Button();
            this.ADDBT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.SuspendLayout();
            // 
            // CARDBT
            // 
            this.CARDBT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CARDBT.Location = new System.Drawing.Point(905, 473);
            this.CARDBT.Name = "CARDBT";
            this.CARDBT.Size = new System.Drawing.Size(240, 38);
            this.CARDBT.TabIndex = 0;
            this.CARDBT.Text = "CARD";
            this.CARDBT.UseVisualStyleBackColor = true;
            this.CARDBT.Click += new System.EventHandler(this.CARDBT_Click);
            // 
            // CASHBT
            // 
            this.CASHBT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CASHBT.Location = new System.Drawing.Point(905, 517);
            this.CASHBT.Name = "CASHBT";
            this.CASHBT.Size = new System.Drawing.Size(240, 38);
            this.CASHBT.TabIndex = 1;
            this.CASHBT.Text = "CASH";
            this.CASHBT.UseVisualStyleBackColor = true;
            this.CASHBT.Click += new System.EventHandler(this.CASHBT_Click);
            // 
            // dgv1
            // 
            this.dgv1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgv1.Location = new System.Drawing.Point(12, 112);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.RowHeadersWidth = 51;
            this.dgv1.RowTemplate.Height = 27;
            this.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv1.Size = new System.Drawing.Size(860, 443);
            this.dgv1.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Menu";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Price";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "chinese",
            "japanese",
            "korean",
            "snack",
            "western"});
            this.comboBox1.Location = new System.Drawing.Point(12, 69);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(715, 23);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(745, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "메뉴 보기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgv2
            // 
            this.dgv2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.menu,
            this.Price});
            this.dgv2.Location = new System.Drawing.Point(905, 69);
            this.dgv2.Name = "dgv2";
            this.dgv2.ReadOnly = true;
            this.dgv2.RowHeadersWidth = 51;
            this.dgv2.RowTemplate.Height = 27;
            this.dgv2.Size = new System.Drawing.Size(240, 256);
            this.dgv2.TabIndex = 5;
            
            // 
            // menu
            // 
            this.menu.Frozen = true;
            this.menu.HeaderText = "Menu";
            this.menu.MinimumWidth = 6;
            this.menu.Name = "menu";
            this.menu.ReadOnly = true;
            this.menu.Width = 95;
            // 
            // Price
            // 
            this.Price.Frozen = true;
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 95;
            // 
            // DELETEBT
            // 
            this.DELETEBT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DELETEBT.Location = new System.Drawing.Point(905, 429);
            this.DELETEBT.Name = "DELETEBT";
            this.DELETEBT.Size = new System.Drawing.Size(240, 38);
            this.DELETEBT.TabIndex = 7;
            this.DELETEBT.Text = "DELETE";
            this.DELETEBT.UseVisualStyleBackColor = true;
            this.DELETEBT.Click += new System.EventHandler(this.DELETEBT_Click);
            // 
            // ADDBT
            // 
            this.ADDBT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ADDBT.Location = new System.Drawing.Point(905, 385);
            this.ADDBT.Name = "ADDBT";
            this.ADDBT.Size = new System.Drawing.Size(240, 38);
            this.ADDBT.TabIndex = 6;
            this.ADDBT.Text = "ADD";
            this.ADDBT.UseVisualStyleBackColor = true;
            this.ADDBT.Click += new System.EventHandler(this.ADDBT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gulim", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(902, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "Total : ";
            // 
            // tPrice
            // 
            this.tPrice.AutoSize = true;
            this.tPrice.Font = new System.Drawing.Font("Gulim", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tPrice.Location = new System.Drawing.Point(1019, 339);
            this.tPrice.Name = "tPrice";
            this.tPrice.Size = new System.Drawing.Size(30, 30);
            this.tPrice.TabIndex = 8;
            this.tPrice.Text = "0";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 607);
            this.Controls.Add(this.tPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DELETEBT);
            this.Controls.Add(this.ADDBT);
            this.Controls.Add(this.dgv2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.CASHBT);
            this.Controls.Add(this.CARDBT);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Main";
            this.Text = "Food Court";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CARDBT;
        private System.Windows.Forms.Button CASHBT;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.Button DELETEBT;
        private System.Windows.Forms.Button ADDBT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn menu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tPrice;
    }
}


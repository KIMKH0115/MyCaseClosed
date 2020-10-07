namespace test
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbb1 = new System.Windows.Forms.ComboBox();
            this.cbb2 = new System.Windows.Forms.ComboBox();
            this.cbb3 = new System.Windows.Forms.ComboBox();
            this.cbb4 = new System.Windows.Forms.ComboBox();
            this.cbb5 = new System.Windows.Forms.ComboBox();
            this.OK = new System.Windows.Forms.Button();
            this.CC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(334, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "portname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "baudrate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(334, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "data bits";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(334, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "stop bits";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(334, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "parity";
            // 
            // cbb1
            // 
            this.cbb1.FormattingEnabled = true;
            this.cbb1.Items.AddRange(new object[] {
            "com1",
            "com2",
            "com3",
            "com4",
            "com5"});
            this.cbb1.Location = new System.Drawing.Point(471, 125);
            this.cbb1.Name = "cbb1";
            this.cbb1.Size = new System.Drawing.Size(490, 23);
            this.cbb1.TabIndex = 1;
            // 
            // cbb2
            // 
            this.cbb2.FormattingEnabled = true;
            this.cbb2.Items.AddRange(new object[] {
            "9600",
            "115200",
            "5300",
            "19200"});
            this.cbb2.Location = new System.Drawing.Point(471, 180);
            this.cbb2.Name = "cbb2";
            this.cbb2.Size = new System.Drawing.Size(490, 23);
            this.cbb2.TabIndex = 1;
            // 
            // cbb3
            // 
            this.cbb3.FormattingEnabled = true;
            this.cbb3.Items.AddRange(new object[] {
            "7",
            "8"});
            this.cbb3.Location = new System.Drawing.Point(471, 242);
            this.cbb3.Name = "cbb3";
            this.cbb3.Size = new System.Drawing.Size(490, 23);
            this.cbb3.TabIndex = 1;
            // 
            // cbb4
            // 
            this.cbb4.FormattingEnabled = true;
            this.cbb4.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbb4.Location = new System.Drawing.Point(471, 310);
            this.cbb4.Name = "cbb4";
            this.cbb4.Size = new System.Drawing.Size(490, 23);
            this.cbb4.TabIndex = 1;
            // 
            // cbb5
            // 
            this.cbb5.FormattingEnabled = true;
            this.cbb5.Items.AddRange(new object[] {
            "N",
            "O",
            "E"});
            this.cbb5.Location = new System.Drawing.Point(471, 375);
            this.cbb5.Name = "cbb5";
            this.cbb5.Size = new System.Drawing.Size(490, 23);
            this.cbb5.TabIndex = 1;
            // 
            // OK
            // 
            this.OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK.Location = new System.Drawing.Point(416, 458);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(203, 53);
            this.OK.TabIndex = 2;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // CC
            // 
            this.CC.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CC.Location = new System.Drawing.Point(711, 458);
            this.CC.Name = "CC";
            this.CC.Size = new System.Drawing.Size(203, 53);
            this.CC.TabIndex = 2;
            this.CC.Text = "CANCEL";
            this.CC.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 647);
            this.Controls.Add(this.CC);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.cbb5);
            this.Controls.Add(this.cbb4);
            this.Controls.Add(this.cbb3);
            this.Controls.Add(this.cbb2);
            this.Controls.Add(this.cbb1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Serial Port Setting";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox cbb1;
        public System.Windows.Forms.ComboBox cbb2;
        public System.Windows.Forms.ComboBox cbb3;
        public System.Windows.Forms.ComboBox cbb4;
        public System.Windows.Forms.ComboBox cbb5;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button CC;
    }
}
namespace test
{
    partial class F4
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
            this.alset = new System.Windows.Forms.TextBox();
            this.CC = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(4, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "ALARMSET(S)";
            // 
            // alset
            // 
            this.alset.Location = new System.Drawing.Point(143, 11);
            this.alset.Multiline = true;
            this.alset.Name = "alset";
            this.alset.Size = new System.Drawing.Size(108, 51);
            this.alset.TabIndex = 1;
            this.alset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CC
            // 
            this.CC.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CC.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CC.Location = new System.Drawing.Point(140, 68);
            this.CC.Name = "CC";
            this.CC.Size = new System.Drawing.Size(114, 34);
            this.CC.TabIndex = 3;
            this.CC.Text = "CANCEL";
            this.CC.UseVisualStyleBackColor = true;
            // 
            // OK
            // 
            this.OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.OK.Location = new System.Drawing.Point(9, 68);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(114, 34);
            this.OK.TabIndex = 4;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // F4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 113);
            this.Controls.Add(this.CC);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.alset);
            this.Controls.Add(this.label1);
            this.Name = "F4";
            this.Text = "STOPWATCH SETTING";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox alset;
        private System.Windows.Forms.Button CC;
        private System.Windows.Forms.Button OK;
    }
}
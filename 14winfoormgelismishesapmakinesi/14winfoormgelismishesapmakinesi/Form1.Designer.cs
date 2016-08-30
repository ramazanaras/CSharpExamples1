namespace _14winfoormgelismishesapmakinesi
{
    partial class Form1
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
            this.cmbIslem = new System.Windows.Forms.ComboBox();
            this.nudSayi1 = new System.Windows.Forms.NumericUpDown();
            this.nudSayi2 = new System.Windows.Forms.NumericUpDown();
            this.btnSonuç = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSonuc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudSayi1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSayi2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "1.Sayı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "İşlem";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "2.Sayı";
            // 
            // cmbIslem
            // 
            this.cmbIslem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIslem.FormattingEnabled = true;
            this.cmbIslem.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/",
            "%"});
            this.cmbIslem.Location = new System.Drawing.Point(126, 76);
            this.cmbIslem.Name = "cmbIslem";
            this.cmbIslem.Size = new System.Drawing.Size(120, 21);
            this.cmbIslem.TabIndex = 6;
            // 
            // nudSayi1
            // 
            this.nudSayi1.Location = new System.Drawing.Point(126, 34);
            this.nudSayi1.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.nudSayi1.Name = "nudSayi1";
            this.nudSayi1.Size = new System.Drawing.Size(120, 20);
            this.nudSayi1.TabIndex = 7;
            // 
            // nudSayi2
            // 
            this.nudSayi2.Location = new System.Drawing.Point(126, 112);
            this.nudSayi2.Name = "nudSayi2";
            this.nudSayi2.Size = new System.Drawing.Size(120, 20);
            this.nudSayi2.TabIndex = 8;
            // 
            // btnSonuç
            // 
            this.btnSonuç.Location = new System.Drawing.Point(141, 152);
            this.btnSonuç.Name = "btnSonuç";
            this.btnSonuç.Size = new System.Drawing.Size(75, 23);
            this.btnSonuç.TabIndex = 9;
            this.btnSonuç.Text = "Sonuç";
            this.btnSonuç.UseVisualStyleBackColor = true;
            this.btnSonuç.Click += new System.EventHandler(this.btnSonuç_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Sonuç";
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(123, 186);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(0, 13);
            this.lblSonuc.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 215);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSonuç);
            this.Controls.Add(this.nudSayi2);
            this.Controls.Add(this.nudSayi1);
            this.Controls.Add(this.cmbIslem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSayi1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSayi2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbIslem;
        private System.Windows.Forms.NumericUpDown nudSayi1;
        private System.Windows.Forms.NumericUpDown nudSayi2;
        private System.Windows.Forms.Button btnSonuç;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSonuc;
    }
}


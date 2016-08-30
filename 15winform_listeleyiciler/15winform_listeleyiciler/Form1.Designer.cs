namespace _15winform_listeleyiciler
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
            this.txtIsım = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.listKisiler = new System.Windows.Forms.ListBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsim:";
            // 
            // txtIsım
            // 
            this.txtIsım.Location = new System.Drawing.Point(98, 43);
            this.txtIsım.Name = "txtIsım";
            this.txtIsım.Size = new System.Drawing.Size(134, 20);
            this.txtIsım.TabIndex = 1;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(278, 39);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // listKisiler
            // 
            this.listKisiler.FormattingEnabled = true;
            this.listKisiler.Items.AddRange(new object[] {
            "korkmaz",
            "hasan",
            "burcu",
            "ercan"});
            this.listKisiler.Location = new System.Drawing.Point(53, 69);
            this.listKisiler.Name = "listKisiler";
            this.listKisiler.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listKisiler.Size = new System.Drawing.Size(179, 199);
            this.listKisiler.TabIndex = 3;
            this.listKisiler.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listKisiler_KeyDown);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(278, 84);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnEkle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 293);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.listKisiler);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtIsım);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIsım;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ListBox listKisiler;
        private System.Windows.Forms.Button btnSil;
    }
}


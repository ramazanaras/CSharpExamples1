namespace _23winform_atyarisi
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.atRuzgarGulu = new System.Windows.Forms.PictureBox();
            this.atYagiz = new System.Windows.Forms.PictureBox();
            this.atPoyraz = new System.Windows.Forms.PictureBox();
            this.atGolgeYele = new System.Windows.Forms.PictureBox();
            this.atAlver = new System.Windows.Forms.PictureBox();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.atRuzgarGulu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atYagiz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atPoyraz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atGolgeYele)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atAlver)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 35;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // atRuzgarGulu
            // 
            this.atRuzgarGulu.Image = global::_23winform_atyarisi.Properties.Resources.horse;
            this.atRuzgarGulu.Location = new System.Drawing.Point(46, 38);
            this.atRuzgarGulu.Name = "atRuzgarGulu";
            this.atRuzgarGulu.Size = new System.Drawing.Size(125, 70);
            this.atRuzgarGulu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.atRuzgarGulu.TabIndex = 0;
            this.atRuzgarGulu.TabStop = false;
            // 
            // atYagiz
            // 
            this.atYagiz.Image = global::_23winform_atyarisi.Properties.Resources.horse;
            this.atYagiz.Location = new System.Drawing.Point(46, 114);
            this.atYagiz.Name = "atYagiz";
            this.atYagiz.Size = new System.Drawing.Size(125, 70);
            this.atYagiz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.atYagiz.TabIndex = 0;
            this.atYagiz.TabStop = false;
            // 
            // atPoyraz
            // 
            this.atPoyraz.Image = global::_23winform_atyarisi.Properties.Resources.horse;
            this.atPoyraz.Location = new System.Drawing.Point(46, 190);
            this.atPoyraz.Name = "atPoyraz";
            this.atPoyraz.Size = new System.Drawing.Size(125, 70);
            this.atPoyraz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.atPoyraz.TabIndex = 0;
            this.atPoyraz.TabStop = false;
            // 
            // atGolgeYele
            // 
            this.atGolgeYele.Image = global::_23winform_atyarisi.Properties.Resources.horse;
            this.atGolgeYele.Location = new System.Drawing.Point(46, 266);
            this.atGolgeYele.Name = "atGolgeYele";
            this.atGolgeYele.Size = new System.Drawing.Size(125, 70);
            this.atGolgeYele.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.atGolgeYele.TabIndex = 0;
            this.atGolgeYele.TabStop = false;
            // 
            // atAlver
            // 
            this.atAlver.Image = global::_23winform_atyarisi.Properties.Resources.horse;
            this.atAlver.Location = new System.Drawing.Point(46, 342);
            this.atAlver.Name = "atAlver";
            this.atAlver.Size = new System.Drawing.Size(125, 70);
            this.atAlver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.atAlver.TabIndex = 0;
            this.atAlver.TabStop = false;
            // 
            // btnBaslat
            // 
            this.btnBaslat.Location = new System.Drawing.Point(46, 9);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(125, 23);
            this.btnBaslat.TabIndex = 1;
            this.btnBaslat.Text = "Başlat";
            this.btnBaslat.UseVisualStyleBackColor = true;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(712, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 411);
            this.label1.TabIndex = 2;
            this.label1.Text = "FINISH";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(738, 467);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBaslat);
            this.Controls.Add(this.atAlver);
            this.Controls.Add(this.atGolgeYele);
            this.Controls.Add(this.atPoyraz);
            this.Controls.Add(this.atYagiz);
            this.Controls.Add(this.atRuzgarGulu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.atRuzgarGulu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atYagiz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atPoyraz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atGolgeYele)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atAlver)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox atRuzgarGulu;
        private System.Windows.Forms.PictureBox atYagiz;
        private System.Windows.Forms.PictureBox atPoyraz;
        private System.Windows.Forms.PictureBox atGolgeYele;
        private System.Windows.Forms.PictureBox atAlver;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.Label label1;
    }
}


namespace ProjeHastane
{
    partial class FrmBilgiDüzenle
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
            this.label6 = new System.Windows.Forms.Label();
            this.CmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.MskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.MskTC = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.BtnBilgiDuzenle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(38, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 29);
            this.label6.TabIndex = 34;
            this.label6.Text = "Cinsiyet:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // CmbCinsiyet
            // 
            this.CmbCinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbCinsiyet.FormattingEnabled = true;
            this.CmbCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın",
            "Diğer"});
            this.CmbCinsiyet.Location = new System.Drawing.Point(186, 293);
            this.CmbCinsiyet.Name = "CmbCinsiyet";
            this.CmbCinsiyet.Size = new System.Drawing.Size(169, 33);
            this.CmbCinsiyet.TabIndex = 33;
            // 
            // MskTelefon
            // 
            this.MskTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskTelefon.Location = new System.Drawing.Point(186, 214);
            this.MskTelefon.Mask = "(999) 000-0000";
            this.MskTelefon.Name = "MskTelefon";
            this.MskTelefon.Size = new System.Drawing.Size(169, 34);
            this.MskTelefon.TabIndex = 32;
            // 
            // TxtAd
            // 
            this.TxtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAd.Location = new System.Drawing.Point(186, 78);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(169, 34);
            this.TxtAd.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(38, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 29);
            this.label5.TabIndex = 30;
            this.label5.Text = "Telefon:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TxtSifre
            // 
            this.TxtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSifre.Location = new System.Drawing.Point(186, 253);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(169, 34);
            this.TxtSifre.TabIndex = 29;
            // 
            // MskTC
            // 
            this.MskTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskTC.Location = new System.Drawing.Point(186, 173);
            this.MskTC.Mask = "00000000000";
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(169, 34);
            this.MskTC.TabIndex = 28;
            this.MskTC.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(38, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 29);
            this.label1.TabIndex = 27;
            this.label1.Text = "Şifre:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(38, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 43);
            this.label4.TabIndex = 26;
            this.label4.Text = "TC Kimlik No:";
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSoyad.Location = new System.Drawing.Point(186, 124);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(169, 34);
            this.TxtSoyad.TabIndex = 25;
            // 
            // BtnBilgiDuzenle
            // 
            this.BtnBilgiDuzenle.BackColor = System.Drawing.Color.MidnightBlue;
            this.BtnBilgiDuzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnBilgiDuzenle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnBilgiDuzenle.Location = new System.Drawing.Point(186, 332);
            this.BtnBilgiDuzenle.Name = "BtnBilgiDuzenle";
            this.BtnBilgiDuzenle.Size = new System.Drawing.Size(169, 40);
            this.BtnBilgiDuzenle.TabIndex = 24;
            this.BtnBilgiDuzenle.Text = "GÜNCELLE";
            this.BtnBilgiDuzenle.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(38, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 29);
            this.label3.TabIndex = 23;
            this.label3.Text = "Soyad:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(27, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 43);
            this.label2.TabIndex = 22;
            this.label2.Text = "Ad:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // FrmBilgiDüzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(496, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CmbCinsiyet);
            this.Controls.Add(this.MskTelefon);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.MskTC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtSoyad);
            this.Controls.Add(this.BtnBilgiDuzenle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FrmBilgiDüzenle";
            this.Text = "FrmBilgiDüzenle";
            this.Load += new System.EventHandler(this.FrmBilgiDüzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CmbCinsiyet;
        private System.Windows.Forms.MaskedTextBox MskTelefon;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.MaskedTextBox MskTC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.Button BtnBilgiDuzenle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
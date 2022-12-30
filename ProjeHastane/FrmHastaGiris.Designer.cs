namespace ProjeHastane
{
    partial class FrmHastaGiris
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
            this.BtnGiris = new System.Windows.Forms.Button();
            this.LnkUyeOl = new System.Windows.Forms.LinkLabel();
            this.MskTC = new System.Windows.Forms.MaskedTextBox();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe Script", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(527, 93);
            this.label1.TabIndex = 0;
            this.label1.Text = "HASTA GİRİŞ PANELİ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(44, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 43);
            this.label2.TabIndex = 1;
            this.label2.Text = "TC Kimlik No:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(44, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Şifre:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // BtnGiris
            // 
            this.BtnGiris.Location = new System.Drawing.Point(201, 199);
            this.BtnGiris.Name = "BtnGiris";
            this.BtnGiris.Size = new System.Drawing.Size(144, 49);
            this.BtnGiris.TabIndex = 3;
            this.BtnGiris.Text = "GİRİŞ";
            this.BtnGiris.UseVisualStyleBackColor = true;
            this.BtnGiris.Click += new System.EventHandler(this.BtnGiris_Click);
            // 
            // LnkUyeOl
            // 
            this.LnkUyeOl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LnkUyeOl.Location = new System.Drawing.Point(383, 164);
            this.LnkUyeOl.Name = "LnkUyeOl";
            this.LnkUyeOl.Size = new System.Drawing.Size(105, 32);
            this.LnkUyeOl.TabIndex = 4;
            this.LnkUyeOl.TabStop = true;
            this.LnkUyeOl.Text = "Üye Ol";
            this.LnkUyeOl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkUyeOl_LinkClicked);
            // 
            // MskTC
            // 
            this.MskTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskTC.Location = new System.Drawing.Point(192, 112);
            this.MskTC.Mask = "00000000000";
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(169, 34);
            this.MskTC.TabIndex = 6;
            this.MskTC.ValidatingType = typeof(int);
            // 
            // TxtSifre
            // 
            this.TxtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSifre.Location = new System.Drawing.Point(192, 159);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(169, 34);
            this.TxtSifre.TabIndex = 7;
            // 
            // FrmHastaGiris
            // 
            this.AcceptButton = this.BtnGiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(506, 315);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.MskTC);
            this.Controls.Add(this.LnkUyeOl);
            this.Controls.Add(this.BtnGiris);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FrmHastaGiris";
            this.Text = "FrmHastaGiris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnGiris;
        private System.Windows.Forms.LinkLabel LnkUyeOl;
        private System.Windows.Forms.MaskedTextBox MskTC;
        private System.Windows.Forms.TextBox TxtSifre;
    }
}
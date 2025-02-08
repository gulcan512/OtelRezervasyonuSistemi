namespace OtelRezervasyonuSistemi
{
    partial class FormRezervasyonOlusturma
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
            this.groupBoxMusteri = new System.Windows.Forms.GroupBox();
            this.txtTCNo = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.maskedTxtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lblTCNo = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.groupBoxOda = new System.Windows.Forms.GroupBox();
            this.cmbDurum = new System.Windows.Forms.ComboBox();
            this.cmbOdaTipi = new System.Windows.Forms.ComboBox();
            this.dtpCikisTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtpGirisTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.txtOdaNo = new System.Windows.Forms.TextBox();
            this.lblCikisTarihi = new System.Windows.Forms.Label();
            this.lblGirisTarihi = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.lblOdaTipi = new System.Windows.Forms.Label();
            this.lblOdaNo = new System.Windows.Forms.Label();
            this.btnAnaSayfa = new System.Windows.Forms.Button();
            this.groupBoxMusteri.SuspendLayout();
            this.groupBoxOda.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxMusteri
            // 
            this.groupBoxMusteri.Controls.Add(this.txtTCNo);
            this.groupBoxMusteri.Controls.Add(this.txtSoyad);
            this.groupBoxMusteri.Controls.Add(this.maskedTxtTelefon);
            this.groupBoxMusteri.Controls.Add(this.txtAd);
            this.groupBoxMusteri.Controls.Add(this.lblTCNo);
            this.groupBoxMusteri.Controls.Add(this.lblTelefon);
            this.groupBoxMusteri.Controls.Add(this.lblSoyad);
            this.groupBoxMusteri.Controls.Add(this.lblAd);
            this.groupBoxMusteri.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxMusteri.Location = new System.Drawing.Point(45, 25);
            this.groupBoxMusteri.Name = "groupBoxMusteri";
            this.groupBoxMusteri.Size = new System.Drawing.Size(356, 316);
            this.groupBoxMusteri.TabIndex = 0;
            this.groupBoxMusteri.TabStop = false;
            this.groupBoxMusteri.Text = "MÜŞTERİ";
            // 
            // txtTCNo
            // 
            this.txtTCNo.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTCNo.Location = new System.Drawing.Point(140, 214);
            this.txtTCNo.Name = "txtTCNo";
            this.txtTCNo.Size = new System.Drawing.Size(164, 34);
            this.txtTCNo.TabIndex = 2;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.Location = new System.Drawing.Point(140, 115);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(164, 34);
            this.txtSoyad.TabIndex = 3;
            // 
            // maskedTxtTelefon
            // 
            this.maskedTxtTelefon.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedTxtTelefon.Location = new System.Drawing.Point(140, 166);
            this.maskedTxtTelefon.Name = "maskedTxtTelefon";
            this.maskedTxtTelefon.Size = new System.Drawing.Size(164, 34);
            this.maskedTxtTelefon.TabIndex = 4;
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(140, 69);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(164, 34);
            this.txtAd.TabIndex = 2;
            // 
            // lblTCNo
            // 
            this.lblTCNo.AutoSize = true;
            this.lblTCNo.Location = new System.Drawing.Point(29, 210);
            this.lblTCNo.Name = "lblTCNo";
            this.lblTCNo.Size = new System.Drawing.Size(99, 34);
            this.lblTCNo.TabIndex = 3;
            this.lblTCNo.Text = "TC No";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(23, 162);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(105, 34);
            this.lblTelefon.TabIndex = 2;
            this.lblTelefon.Text = "Telefon";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(39, 115);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(89, 34);
            this.lblSoyad.TabIndex = 1;
            this.lblSoyad.Text = "Soyad";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(77, 69);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(51, 34);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "Ad";
            // 
            // groupBoxOda
            // 
            this.groupBoxOda.Controls.Add(this.cmbDurum);
            this.groupBoxOda.Controls.Add(this.cmbOdaTipi);
            this.groupBoxOda.Controls.Add(this.dtpCikisTarihi);
            this.groupBoxOda.Controls.Add(this.dtpGirisTarihi);
            this.groupBoxOda.Controls.Add(this.txtFiyat);
            this.groupBoxOda.Controls.Add(this.txtOdaNo);
            this.groupBoxOda.Controls.Add(this.lblCikisTarihi);
            this.groupBoxOda.Controls.Add(this.lblGirisTarihi);
            this.groupBoxOda.Controls.Add(this.lblFiyat);
            this.groupBoxOda.Controls.Add(this.lblDurum);
            this.groupBoxOda.Controls.Add(this.lblOdaTipi);
            this.groupBoxOda.Controls.Add(this.lblOdaNo);
            this.groupBoxOda.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxOda.Location = new System.Drawing.Point(445, 25);
            this.groupBoxOda.Name = "groupBoxOda";
            this.groupBoxOda.Size = new System.Drawing.Size(532, 359);
            this.groupBoxOda.TabIndex = 1;
            this.groupBoxOda.TabStop = false;
            this.groupBoxOda.Text = "ODA";
            // 
            // cmbDurum
            // 
            this.cmbDurum.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbDurum.FormattingEnabled = true;
            this.cmbDurum.Location = new System.Drawing.Point(26, 263);
            this.cmbDurum.Name = "cmbDurum";
            this.cmbDurum.Size = new System.Drawing.Size(173, 34);
            this.cmbDurum.TabIndex = 11;
            // 
            // cmbOdaTipi
            // 
            this.cmbOdaTipi.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbOdaTipi.FormattingEnabled = true;
            this.cmbOdaTipi.Location = new System.Drawing.Point(26, 179);
            this.cmbOdaTipi.Name = "cmbOdaTipi";
            this.cmbOdaTipi.Size = new System.Drawing.Size(173, 34);
            this.cmbOdaTipi.TabIndex = 10;
            // 
            // dtpCikisTarihi
            // 
            this.dtpCikisTarihi.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpCikisTarihi.Location = new System.Drawing.Point(278, 274);
            this.dtpCikisTarihi.Name = "dtpCikisTarihi";
            this.dtpCikisTarihi.Size = new System.Drawing.Size(187, 34);
            this.dtpCikisTarihi.TabIndex = 9;
            // 
            // dtpGirisTarihi
            // 
            this.dtpGirisTarihi.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpGirisTarihi.Location = new System.Drawing.Point(278, 189);
            this.dtpGirisTarihi.Name = "dtpGirisTarihi";
            this.dtpGirisTarihi.Size = new System.Drawing.Size(187, 34);
            this.dtpGirisTarihi.TabIndex = 8;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFiyat.Location = new System.Drawing.Point(278, 91);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(187, 34);
            this.txtFiyat.TabIndex = 7;
            // 
            // txtOdaNo
            // 
            this.txtOdaNo.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOdaNo.Location = new System.Drawing.Point(26, 91);
            this.txtOdaNo.Name = "txtOdaNo";
            this.txtOdaNo.Size = new System.Drawing.Size(174, 34);
            this.txtOdaNo.TabIndex = 6;
            // 
            // lblCikisTarihi
            // 
            this.lblCikisTarihi.AutoSize = true;
            this.lblCikisTarihi.Location = new System.Drawing.Point(272, 237);
            this.lblCikisTarihi.Name = "lblCikisTarihi";
            this.lblCikisTarihi.Size = new System.Drawing.Size(150, 34);
            this.lblCikisTarihi.TabIndex = 5;
            this.lblCikisTarihi.Text = "Çıkış Tarihi";
            // 
            // lblGirisTarihi
            // 
            this.lblGirisTarihi.AutoSize = true;
            this.lblGirisTarihi.Location = new System.Drawing.Point(277, 142);
            this.lblGirisTarihi.Name = "lblGirisTarihi";
            this.lblGirisTarihi.Size = new System.Drawing.Size(148, 34);
            this.lblGirisTarihi.TabIndex = 4;
            this.lblGirisTarihi.Text = "Giriş Tarihi";
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(272, 54);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(74, 34);
            this.lblFiyat.TabIndex = 3;
            this.lblFiyat.Text = "Fiyat";
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Location = new System.Drawing.Point(20, 226);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(100, 34);
            this.lblDurum.TabIndex = 2;
            this.lblDurum.Text = "Durum";
            // 
            // lblOdaTipi
            // 
            this.lblOdaTipi.AutoSize = true;
            this.lblOdaTipi.Location = new System.Drawing.Point(20, 142);
            this.lblOdaTipi.Name = "lblOdaTipi";
            this.lblOdaTipi.Size = new System.Drawing.Size(119, 34);
            this.lblOdaTipi.TabIndex = 1;
            this.lblOdaTipi.Text = "Oda Tipi";
            // 
            // lblOdaNo
            // 
            this.lblOdaNo.AutoSize = true;
            this.lblOdaNo.Location = new System.Drawing.Point(20, 54);
            this.lblOdaNo.Name = "lblOdaNo";
            this.lblOdaNo.Size = new System.Drawing.Size(187, 34);
            this.lblOdaNo.TabIndex = 0;
            this.lblOdaNo.Text = "Oda Numarası";
            // 
            // btnAnaSayfa
            // 
            this.btnAnaSayfa.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnaSayfa.Location = new System.Drawing.Point(664, 402);
            this.btnAnaSayfa.Name = "btnAnaSayfa";
            this.btnAnaSayfa.Size = new System.Drawing.Size(151, 60);
            this.btnAnaSayfa.TabIndex = 2;
            this.btnAnaSayfa.Text = "Ana Sayfaya Dön";
            this.btnAnaSayfa.UseVisualStyleBackColor = true;
            this.btnAnaSayfa.Click += new System.EventHandler(this.btnAnaSayfa_Click);
            // 
            // FormRezervasyonOlusturma
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1109, 584);
            this.Controls.Add(this.btnAnaSayfa);
            this.Controls.Add(this.groupBoxOda);
            this.Controls.Add(this.groupBoxMusteri);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRezervasyonOlusturma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRezervasyonOlusturma";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormRezervasyonOlusturma_Load);
            this.groupBoxMusteri.ResumeLayout(false);
            this.groupBoxMusteri.PerformLayout();
            this.groupBoxOda.ResumeLayout(false);
            this.groupBoxOda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMusteri;
        private System.Windows.Forms.TextBox txtTCNo;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.MaskedTextBox maskedTxtTelefon;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label lblTCNo;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.GroupBox groupBoxOda;
        private System.Windows.Forms.Label lblCikisTarihi;
        private System.Windows.Forms.Label lblGirisTarihi;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Label lblOdaTipi;
        private System.Windows.Forms.Label lblOdaNo;
        private System.Windows.Forms.ComboBox cmbDurum;
        private System.Windows.Forms.ComboBox cmbOdaTipi;
        private System.Windows.Forms.DateTimePicker dtpCikisTarihi;
        private System.Windows.Forms.DateTimePicker dtpGirisTarihi;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.TextBox txtOdaNo;
        private System.Windows.Forms.Button btnAnaSayfa;
    }
}
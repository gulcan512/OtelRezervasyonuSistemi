namespace OtelRezervasyonuSistemi
{
    partial class FormGiris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblOtel = new System.Windows.Forms.Label();
            this.lblKullanıcı = new System.Windows.Forms.Label();
            this.lblParola = new System.Windows.Forms.Label();
            this.txtKullanici = new System.Windows.Forms.TextBox();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.groupBoxIslem = new System.Windows.Forms.GroupBox();
            this.btnRzrSil = new System.Windows.Forms.Button();
            this.btnRzrGoruntule = new System.Windows.Forms.Button();
            this.btnRzrOlustur = new System.Windows.Forms.Button();
            this.groupBoxIslem.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOtel
            // 
            this.lblOtel.AutoSize = true;
            this.lblOtel.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOtel.Location = new System.Drawing.Point(217, 9);
            this.lblOtel.Name = "lblOtel";
            this.lblOtel.Size = new System.Drawing.Size(284, 42);
            this.lblOtel.TabIndex = 0;
            this.lblOtel.Text = "ANEMON OTEL";
            // 
            // lblKullanıcı
            // 
            this.lblKullanıcı.AutoSize = true;
            this.lblKullanıcı.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullanıcı.Location = new System.Drawing.Point(369, 106);
            this.lblKullanıcı.Name = "lblKullanıcı";
            this.lblKullanıcı.Size = new System.Drawing.Size(164, 33);
            this.lblKullanıcı.TabIndex = 1;
            this.lblKullanıcı.Text = "Kullanıcı Adı";
            // 
            // lblParola
            // 
            this.lblParola.AutoSize = true;
            this.lblParola.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblParola.Location = new System.Drawing.Point(369, 158);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(86, 33);
            this.lblParola.TabIndex = 2;
            this.lblParola.Text = "Parola";
            // 
            // txtKullanici
            // 
            this.txtKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullanici.Location = new System.Drawing.Point(588, 106);
            this.txtKullanici.Name = "txtKullanici";
            this.txtKullanici.Size = new System.Drawing.Size(180, 34);
            this.txtKullanici.TabIndex = 3;
            // 
            // txtParola
            // 
            this.txtParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtParola.Location = new System.Drawing.Point(588, 158);
            this.txtParola.Name = "txtParola";
            this.txtParola.Size = new System.Drawing.Size(180, 34);
            this.txtParola.TabIndex = 4;
            // 
            // btnGiris
            // 
            this.btnGiris.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.Location = new System.Drawing.Point(594, 220);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(114, 42);
            this.btnGiris.TabIndex = 5;
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // groupBoxIslem
            // 
            this.groupBoxIslem.Controls.Add(this.btnRzrSil);
            this.groupBoxIslem.Controls.Add(this.btnRzrGoruntule);
            this.groupBoxIslem.Controls.Add(this.btnRzrOlustur);
            this.groupBoxIslem.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxIslem.Location = new System.Drawing.Point(328, 291);
            this.groupBoxIslem.Name = "groupBoxIslem";
            this.groupBoxIslem.Size = new System.Drawing.Size(440, 202);
            this.groupBoxIslem.TabIndex = 6;
            this.groupBoxIslem.TabStop = false;
            this.groupBoxIslem.Text = "Lütfen Yapmak İstediğiniz İşlemi Seçiniz";
            // 
            // btnRzrSil
            // 
            this.btnRzrSil.Location = new System.Drawing.Point(32, 133);
            this.btnRzrSil.Name = "btnRzrSil";
            this.btnRzrSil.Size = new System.Drawing.Size(381, 44);
            this.btnRzrSil.TabIndex = 2;
            this.btnRzrSil.Text = "Rezervasyon Sil";
            this.btnRzrSil.UseVisualStyleBackColor = true;
            this.btnRzrSil.Click += new System.EventHandler(this.btnRzrSil_Click);
            // 
            // btnRzrGoruntule
            // 
            this.btnRzrGoruntule.Location = new System.Drawing.Point(32, 82);
            this.btnRzrGoruntule.Name = "btnRzrGoruntule";
            this.btnRzrGoruntule.Size = new System.Drawing.Size(381, 45);
            this.btnRzrGoruntule.TabIndex = 1;
            this.btnRzrGoruntule.Text = "Rezervasyon Görüntüle";
            this.btnRzrGoruntule.UseVisualStyleBackColor = true;
            this.btnRzrGoruntule.Click += new System.EventHandler(this.btnRzrGoruntule_Click);
            // 
            // btnRzrOlustur
            // 
            this.btnRzrOlustur.Location = new System.Drawing.Point(32, 33);
            this.btnRzrOlustur.Name = "btnRzrOlustur";
            this.btnRzrOlustur.Size = new System.Drawing.Size(381, 43);
            this.btnRzrOlustur.TabIndex = 0;
            this.btnRzrOlustur.Text = "Rezervasyon Oluştur";
            this.btnRzrOlustur.UseVisualStyleBackColor = true;
            this.btnRzrOlustur.Click += new System.EventHandler(this.btnRzrOlustur_Click);
            // 
            // FormGiris
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1070, 530);
            this.Controls.Add(this.groupBoxIslem);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.txtKullanici);
            this.Controls.Add(this.lblParola);
            this.Controls.Add(this.lblKullanıcı);
            this.Controls.Add(this.lblOtel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormGiris_Load);
            this.groupBoxIslem.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOtel;
        private System.Windows.Forms.Label lblKullanıcı;
        private System.Windows.Forms.Label lblParola;
        private System.Windows.Forms.TextBox txtKullanici;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.GroupBox groupBoxIslem;
        private System.Windows.Forms.Button btnRzrSil;
        private System.Windows.Forms.Button btnRzrGoruntule;
        private System.Windows.Forms.Button btnRzrOlustur;
    }
}


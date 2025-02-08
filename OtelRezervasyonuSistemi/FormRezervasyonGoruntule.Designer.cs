namespace OtelRezervasyonuSistemi
{
    partial class FormRezervasyonGoruntule
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
            this.lstRezervasyonGoruntule = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAnaSayfa = new System.Windows.Forms.Button();
            this.lblRzrGoruntule = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstRezervasyonGoruntule
            // 
            this.lstRezervasyonGoruntule.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstRezervasyonGoruntule.FormattingEnabled = true;
            this.lstRezervasyonGoruntule.ItemHeight = 22;
            this.lstRezervasyonGoruntule.Location = new System.Drawing.Point(210, 92);
            this.lstRezervasyonGoruntule.Name = "lstRezervasyonGoruntule";
            this.lstRezervasyonGoruntule.Size = new System.Drawing.Size(450, 290);
            this.lstRezervasyonGoruntule.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(210, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 64);
            this.button1.TabIndex = 2;
            this.button1.Text = "Rezervasyonları Göster";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnAnaSayfa
            // 
            this.btnAnaSayfa.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnaSayfa.Location = new System.Drawing.Point(446, 390);
            this.btnAnaSayfa.Name = "btnAnaSayfa";
            this.btnAnaSayfa.Size = new System.Drawing.Size(214, 64);
            this.btnAnaSayfa.TabIndex = 3;
            this.btnAnaSayfa.Text = "Ana Sayfaya Dön";
            this.btnAnaSayfa.UseVisualStyleBackColor = true;
            // 
            // lblRzrGoruntule
            // 
            this.lblRzrGoruntule.AutoSize = true;
            this.lblRzrGoruntule.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRzrGoruntule.Location = new System.Drawing.Point(231, 56);
            this.lblRzrGoruntule.Name = "lblRzrGoruntule";
            this.lblRzrGoruntule.Size = new System.Drawing.Size(400, 33);
            this.lblRzrGoruntule.TabIndex = 4;
            this.lblRzrGoruntule.Text = "Detaylar için rezervasyonu seçiniz.";
            // 
            // FormRezervasyonGoruntule
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(947, 528);
            this.Controls.Add(this.lblRzrGoruntule);
            this.Controls.Add(this.btnAnaSayfa);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstRezervasyonGoruntule);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRezervasyonGoruntule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRezervasyonGoruntule";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstRezervasyonGoruntule;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAnaSayfa;
        private System.Windows.Forms.Label lblRzrGoruntule;
    }
}
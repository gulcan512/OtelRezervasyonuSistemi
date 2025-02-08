namespace OtelRezervasyonuSistemi
{
    partial class FormRezervasyonSilme
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
            this.lblRzrSil = new System.Windows.Forms.Label();
            this.lstRezervasyonSilme = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRzrSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRzrSil
            // 
            this.lblRzrSil.AutoSize = true;
            this.lblRzrSil.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRzrSil.Location = new System.Drawing.Point(158, 74);
            this.lblRzrSil.Name = "lblRzrSil";
            this.lblRzrSil.Size = new System.Drawing.Size(533, 33);
            this.lblRzrSil.TabIndex = 0;
            this.lblRzrSil.Text = "Lütfen silmek istediğiniz rezervasyonu seçiniz.";
            // 
            // lstRezervasyonSilme
            // 
            this.lstRezervasyonSilme.FormattingEnabled = true;
            this.lstRezervasyonSilme.ItemHeight = 16;
            this.lstRezervasyonSilme.Location = new System.Drawing.Point(241, 132);
            this.lstRezervasyonSilme.Name = "lstRezervasyonSilme";
            this.lstRezervasyonSilme.Size = new System.Drawing.Size(363, 196);
            this.lstRezervasyonSilme.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(241, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 59);
            this.button1.TabIndex = 2;
            this.button1.Text = "Rezervasyonları Göster";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnRzrSil
            // 
            this.btnRzrSil.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRzrSil.Location = new System.Drawing.Point(437, 334);
            this.btnRzrSil.Name = "btnRzrSil";
            this.btnRzrSil.Size = new System.Drawing.Size(167, 59);
            this.btnRzrSil.TabIndex = 3;
            this.btnRzrSil.Text = "Rezervasyonu Sil";
            this.btnRzrSil.UseVisualStyleBackColor = true;
            // 
            // FormRezervasyonSilme
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(889, 487);
            this.Controls.Add(this.btnRzrSil);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstRezervasyonSilme);
            this.Controls.Add(this.lblRzrSil);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRezervasyonSilme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRezervasyonSilme";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRzrSil;
        private System.Windows.Forms.ListBox lstRezervasyonSilme;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRzrSil;
    }
}
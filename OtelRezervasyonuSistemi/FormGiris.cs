using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelRezervasyonuSistemi
{
    public partial class FormGiris : Form
    {
        public FormGiris()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            // Sabit yönetici bilgileri
            string yoneticiAdi = "admin";
            string yoneticiSifre = "1234";

            if (txtKullanici.Text == yoneticiAdi && txtParola.Text == yoneticiSifre)
            {
                MessageBox.Show("Giriş Başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Butonları aktif hale getir
                btnRzrOlustur.Enabled = true;
                btnRzrGoruntule.Enabled = true;
                btnRzrSil.Enabled = true;
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya parola!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRzrOlustur_Click(object sender, EventArgs e)
        {
            FormRezervasyonOlusturma frm = new FormRezervasyonOlusturma();
            frm.Show();
        }

        private void btnRzrGoruntule_Click(object sender, EventArgs e)
        {
            FormRezervasyonGoruntule frm = new FormRezervasyonGoruntule();
            frm.Show();
        }

        private void btnRzrSil_Click(object sender, EventArgs e)
        {
            FormRezervasyonSilme frm = new FormRezervasyonSilme();
            frm.Show();
        }

        private void FormGiris_Load(object sender, EventArgs e)
        {
            // Başlangıçta butonları devre dışı bırak
            btnRzrOlustur.Enabled = false;
            btnRzrGoruntule.Enabled = false;
            btnRzrSil.Enabled = false;
        }
    }
    }
    
    

    
   
    


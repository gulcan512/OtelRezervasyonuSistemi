using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using OtelRezervasyonuSistemi.DAL;
using OtelRezervasyonuSistemi.DOMAIN;
using OtelRezervasyonuSistemi.SERVICE;

namespace OtelRezervasyonuSistemi
{
    public partial class FormRezervasyonOlusturma : Form
    {
        public List<Rezervasyon> rezervasyonlar = new List<Rezervasyon>();

        private RezervasyonSERVICE rezervasyonService;

        public FormRezervasyonOlusturma()
        {
            InitializeComponent();
            rezervasyonService = new RezervasyonSERVICE();
        }

        // Rezervasyon Ekle Butonu
        private void btnRezervasyonEkle_Click(object sender, EventArgs e)
        {
            try
            {
                // Formdaki alanlardan bilgileri al
                string ad = txtAd.Text;
                string soyad = txtSoyad.Text;
                string telefon = maskedTxtTelefon.Text;
                string tcNo = txtTCNo.Text;
                int odaNumarasi = int.Parse(txtOdaNo.Text);
                string odaTipi = cmbOdaTipi.Text;
                decimal fiyat = 0; // Eğer fiyat bilgisi gerekiyorsa formdan alabilirsin
                bool durum = true; // Varsayılan olarak "aktif" kabul ediyoruz
                DateTime girisTarihi = dtpGirisTarihi.Value;
                DateTime cikisTarihi = dtpCikisTarihi.Value;

                // Rezervasyonu ekle
                bool basarili = rezervasyonService.RezervasyonEkle(ad, soyad, telefon, tcNo, odaNumarasi, odaTipi, fiyat, durum, girisTarihi, cikisTarihi);

                if (basarili)
                {
                    MessageBox.Show("Rezervasyon başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Rezervasyon eklenirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Ana Sayfa Butonu

        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormGiris anaSayfa = new FormGiris();
            anaSayfa.Show();
        }

        private void FormRezervasyonOlusturma_Load(object sender, EventArgs e)
        {
            try
            {
                // Veritabanından rezervasyonları getir
                var rezervasyonlar = rezervasyonService.RezervasyonlariGetir();

                if (rezervasyonlar.Rows.Count > 0)
                {
                    // İlk rezervasyon bilgilerini uygun alanlara doldur
                    DataRow row = rezervasyonlar.Rows[0];
                    txtAd.Text = row["ad"].ToString();
                    txtSoyad.Text = row["soyad"].ToString();
                    maskedTxtTelefon.Text = row["telefon"].ToString();
                    txtTCNo.Text = row["tc_no"].ToString();
                    txtOdaNo.Text = row["oda_numarasi"].ToString();
                    cmbOdaTipi.Text = row["oda_tipi"].ToString();
                    cmbDurum.Text = row["durum"].ToString();
                    dtpGirisTarihi.Value = Convert.ToDateTime(row["giris_tarihi"]);
                    dtpCikisTarihi.Value = Convert.ToDateTime(row["cikis_tarihi"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }



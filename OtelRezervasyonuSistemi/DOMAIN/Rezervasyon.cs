using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyonuSistemi.DOMAIN
{
    public class Rezervasyon
    {
        public int rezervasyonID { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string telefon { get; set; }
        public string tcno { get; set; }
        public int odanumarasi { get; set; }
        public string odatipi { get; set; }
        public decimal fiyat { get; set; }
        public string durum { get; set; }
        public DateTime giristarihi { get; set; }
        public DateTime cikistarihi { get; set; }

        // Yapıcı metod
        public Rezervasyon() { }

        public Rezervasyon(int rezervasyonID, string ad, string soyad, string telefon, string tcno, int odaNumarasi, string odaTipi, decimal fiyat, string durum, DateTime girisTarihi, DateTime cikisTarihi)
        {
            this.rezervasyonID = rezervasyonID;
            this.ad = ad;
            this.soyad = soyad;
            this.telefon = telefon;
            this.tcno = tcno;
            this.odanumarasi = odaNumarasi;
            this.odatipi = odaTipi;
            this.fiyat = fiyat;
            this.durum = durum;
            this.giristarihi = girisTarihi;
            this.cikistarihi = cikisTarihi;
        }
    }
}

    


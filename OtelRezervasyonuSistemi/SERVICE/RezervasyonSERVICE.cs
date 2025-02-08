using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OtelRezervasyonuSistemi.DAL;
using OtelRezervasyonuSistemi.DOMAIN;

namespace OtelRezervasyonuSistemi.SERVICE
{
    public class RezervasyonSERVICE
    {
        private RezervasyonDAO rezervasyonDAO;

        public RezervasyonSERVICE()
        {
            rezervasyonDAO = new RezervasyonDAO();
        }

        public bool RezervasyonEkle(string ad, string soyad, string telefon, string tc_no, int odaNumarasi, string odaTipi, decimal fiyat, bool durum, DateTime girisTarihi, DateTime cikisTarihi)
        {
            string durumStr = durum ? "true" : "false"; // MySQL için bool değerini string olarak ayarlıyoruz
            return rezervasyonDAO.RezervasyonEkle(ad, soyad, telefon, tc_no, odaNumarasi, odaTipi, fiyat, durumStr, girisTarihi, cikisTarihi);
        }

        public DataTable RezervasyonlariGetir()
        {
            return rezervasyonDAO.RezervasyonlariGetir();
        }

        public bool RezervasyonGuncelle(int rezervasyonID, string ad, string soyad, string telefon, string tc_no, int odaNumarasi, string odaTipi, decimal fiyat, bool durum, DateTime girisTarihi, DateTime cikisTarihi)
        {
            string durumStr = durum ? "true" : "false";
            return rezervasyonDAO.RezervasyonGuncelle(rezervasyonID, ad, soyad, telefon, tc_no, odaNumarasi, odaTipi, fiyat, durumStr, girisTarihi, cikisTarihi);
        }

        public bool RezervasyonSil(int rezervasyonID)
        {
            return rezervasyonDAO.RezervasyonSil(rezervasyonID);
        }
    }
}

    

    


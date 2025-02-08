using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using OtelRezervasyonuSistemi.DOMAIN;

namespace OtelRezervasyonuSistemi.DAL
{
    public class RezervasyonDAO
    {
        private string connectionString = "server=172.21.54.253;database=25_132330081;user=25_132330081;password=!nif.ogr81UY;";

        // Rezervasyon Ekle
        public bool RezervasyonEkle(string ad, string soyad, string telefon, string tc_no, int odaNumarasi, string odaTipi, decimal fiyat, string durum, DateTime girisTarihi, DateTime cikisTarihi)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "INSERT INTO Rezervasyon (ad, soyad, telefon, tc_no, oda_numarasi, oda_tipi, fiyat, durum, giris_tarihi, cikis_tarihi) " +
                               "VALUES (@ad, @soyad, @telefon, @tc_no, @oda_numarasi, @oda_tipi, @fiyat, @durum, @giris_tarihi, @cikis_tarihi)";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ad", ad);
                cmd.Parameters.AddWithValue("@soyad", soyad);
                cmd.Parameters.AddWithValue("@telefon", telefon);
                cmd.Parameters.AddWithValue("@tc_no", tc_no);
                cmd.Parameters.AddWithValue("@oda_numarasi", odaNumarasi);
                cmd.Parameters.AddWithValue("@oda_tipi", odaTipi);
                cmd.Parameters.AddWithValue("@fiyat", fiyat);
                cmd.Parameters.AddWithValue("@durum", durum);
                cmd.Parameters.AddWithValue("@giris_tarihi", girisTarihi);
                cmd.Parameters.AddWithValue("@cikis_tarihi", cikisTarihi);

                conn.Open();
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
        }

        // Rezervasyonları Getir
        public DataTable RezervasyonlariGetir()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM Rezervasyon";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // Rezervasyon Güncelle
        public bool RezervasyonGuncelle(int rezervasyonID, string ad, string soyad, string telefon, string tc_no, int odaNumarasi, string odaTipi, decimal fiyat, string durum, DateTime girisTarihi, DateTime cikisTarihi)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "UPDATE Rezervasyon SET ad=@ad, soyad=@soyad, telefon=@telefon, tc_no=@tc_no, oda_numarasi=@oda_numarasi, " +
                               "oda_tipi=@oda_tipi, fiyat=@fiyat, durum=@durum, giris_tarihi=@giris_tarihi, cikis_tarihi=@cikis_tarihi WHERE rezervasyonID=@rezervasyonID";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@rezervasyonID", rezervasyonID);
                cmd.Parameters.AddWithValue("@ad", ad);
                cmd.Parameters.AddWithValue("@soyad", soyad);
                cmd.Parameters.AddWithValue("@telefon", telefon);
                cmd.Parameters.AddWithValue("@tc_no", tc_no);
                cmd.Parameters.AddWithValue("@oda_numarasi", odaNumarasi);
                cmd.Parameters.AddWithValue("@oda_tipi", odaTipi);
                cmd.Parameters.AddWithValue("@fiyat", fiyat);
                cmd.Parameters.AddWithValue("@durum", durum);
                cmd.Parameters.AddWithValue("@giris_tarihi", girisTarihi);
                cmd.Parameters.AddWithValue("@cikis_tarihi", cikisTarihi);

                conn.Open();
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
        }

        // Rezervasyon Sil
        public bool RezervasyonSil(int rezervasyonID)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "DELETE FROM Rezervasyon WHERE rezervasyonID=@rezervasyonID";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@rezervasyonID", rezervasyonID);

                conn.Open();
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
        }
    }
}
    


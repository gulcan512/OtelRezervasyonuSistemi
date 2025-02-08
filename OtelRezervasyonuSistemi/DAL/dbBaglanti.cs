using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OtelRezervasyonuSistemi.DAL
{
    public class dbBaglanti
    {
        public MySqlConnection baglantiGetir()
        {
            MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.253; Database=25_132330081; Uid=25_132330081; Pwd=!nif.ogr81UY");
            baglanti.Open();
            return baglanti;
        }
    }
}
    


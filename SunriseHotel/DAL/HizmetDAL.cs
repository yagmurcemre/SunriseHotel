using MySql.Data.MySqlClient;
using SunriseHotel.ENTITIES;
using System.Collections.Generic;
using System;

namespace SunriseHotel.DAL
{
    public class HizmetDal
    {
        public void HizmetEkle(Hizmet hizmet)
        {
            using (var connection = Baglanti.BaglantiGetir())
            {
                string query = "INSERT INTO Hizmetler (HizmetAd, HizmetFiyat) VALUES (@p1, @p2)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@p1", hizmet.HizmetAd);
                cmd.Parameters.AddWithValue("@p2", hizmet.HizmetFiyat);
                cmd.ExecuteNonQuery();
            }
        }

        public void HizmetGuncelle(Hizmet hizmet)
        {
            using (var connection = Baglanti.BaglantiGetir())
            {
                string query = "UPDATE Hizmetler SET HizmetAd=@p1, HizmetFiyat=@p2 WHERE HizmetID=@p3";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@p1", hizmet.HizmetAd);
                cmd.Parameters.AddWithValue("@p2", hizmet.HizmetFiyat);
                cmd.Parameters.AddWithValue("@p3", hizmet.HizmetID);
                cmd.ExecuteNonQuery();
            }
        }

        public void HizmetSil(Hizmet hizmet)
        {
            using (var connection = Baglanti.BaglantiGetir())
            {
                string query = "DELETE FROM Hizmetler WHERE HizmetID=@p1";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@p1", hizmet.HizmetID);
                cmd.ExecuteNonQuery();
            }
        }

        public List<Hizmet> HizmetListele()
        {
            List<Hizmet> hizmetler = new List<Hizmet>();
            using (var connection = Baglanti.BaglantiGetir())
            {
                string query = "SELECT * FROM Hizmetler";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    hizmetler.Add(new Hizmet
                    {
                        HizmetID = Convert.ToInt32(dr["HizmetID"]),
                        HizmetAd = dr["HizmetAd"].ToString(),
                        HizmetFiyat = Convert.ToDecimal(dr["HizmetFiyat"])
                    });
                }
            }
            return hizmetler;
        }
    }
}

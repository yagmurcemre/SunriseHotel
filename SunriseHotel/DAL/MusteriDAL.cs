using MySql.Data.MySqlClient;
using SunriseHotel.ENTITIES;
using System.Collections.Generic;
using System;

namespace SunriseHotel.DAL
{
    public class MusteriDal
    {
        public void MusteriEkle(Musteri musteri)
        {
            using (var connection = Baglanti.BaglantiGetir())
            {
                string query = "INSERT INTO Musteriler (MusteriAd, MusteriSoyad, TcKimlik, MusteriTelNo) VALUES (@p1, @p2, @p3, @p4)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@p1", musteri.MusteriAd);
                cmd.Parameters.AddWithValue("@p2", musteri.MusteriSoyad);
                cmd.Parameters.AddWithValue("@p3", musteri.TcKimlik);
                cmd.Parameters.AddWithValue("@p4", musteri.MusteriTelNo);
                cmd.ExecuteNonQuery();
            }
        }

        public void MusteriGuncelle(Musteri musteri)
        {
            using (var connection = Baglanti.BaglantiGetir())
            {
                string query = "UPDATE Musteriler SET MusteriAd=@p1, MusteriSoyad=@p2, TcKimlik=@p3, MusteriTelNo=@p4 WHERE MusteriID=@p5";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@p1", musteri.MusteriAd);
                cmd.Parameters.AddWithValue("@p2", musteri.MusteriSoyad);
                cmd.Parameters.AddWithValue("@p3", musteri.TcKimlik);
                cmd.Parameters.AddWithValue("@p4", musteri.MusteriTelNo);
                cmd.Parameters.AddWithValue("@p5", musteri.MusteriID);
                cmd.ExecuteNonQuery();
            }
        }

        public void MusteriSil(Musteri musteri)
        {
            using (var connection = Baglanti.BaglantiGetir())
            {
                string query = "DELETE FROM Musteriler WHERE MusteriID=@p1";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@p1", musteri.MusteriID);
                cmd.ExecuteNonQuery();
            }
        }

        public List<Musteri> MusteriListele()
        {
            List<Musteri> musteriler = new List<Musteri>();
            using (var connection = Baglanti.BaglantiGetir())
            {
                string query = "SELECT * FROM Musteriler";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    musteriler.Add(new Musteri
                    {
                        MusteriID = Convert.ToInt32(dr["MusteriID"]),
                        MusteriAd = dr["MusteriAd"].ToString(),
                        MusteriSoyad = dr["MusteriSoyad"].ToString(),
                        TcKimlik = dr["TcKimlik"].ToString(),
                        MusteriTelNo = dr["MusteriTelNo"].ToString()
                    });
                }
            }
            return musteriler;
        }

        public bool TcKimlikFarkli(string tcKimlik)
        {
            using (var connection = Baglanti.BaglantiGetir())
            {
                string query = "SELECT COUNT(*) FROM Musteriler WHERE TcKimlik=@p1";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@p1", tcKimlik);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count == 0;
            }
        }
    }
}

using MySql.Data.MySqlClient;
using SunriseHotel.ENTITIES;
using System.Collections.Generic;
using System;

namespace SunriseHotel.DAL
{
    public class KullaniciDal
    {
        public void KullaniciEkle(Kullanici kullanici)
        {
            using (var connection = Baglanti.BaglantiGetir())
            {
                string query = "INSERT INTO Kullanicilar (KullaniciAdi, Sifre) VALUES (@p1, @p2)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@p1", kullanici.KullaniciAdi);
                cmd.Parameters.AddWithValue("@p2", kullanici.Sifre);
                cmd.ExecuteNonQuery();
            }
        }

        public void KullaniciGuncelle(Kullanici kullanici)
        {
            using (var connection = Baglanti.BaglantiGetir())
            {
                string query = "UPDATE Kullanicilar SET KullaniciAdi=@p1, Sifre=@p2 WHERE KullaniciID=@p3";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@p1", kullanici.KullaniciAdi);
                cmd.Parameters.AddWithValue("@p2", kullanici.Sifre);
                cmd.Parameters.AddWithValue("@p3", kullanici.KullaniciID);
                cmd.ExecuteNonQuery();
            }
        }

        public void KullaniciSil(Kullanici kullanici)
        {
            using (var connection = Baglanti.BaglantiGetir())
            {
                string query = "DELETE FROM Kullanicilar WHERE KullaniciID=@p1";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@p1", kullanici.KullaniciID);
                cmd.ExecuteNonQuery();
            }
        }

        public List<Kullanici> KullaniciListele()
        {
            List<Kullanici> kullanicilar = new List<Kullanici>();
            using (var connection = Baglanti.BaglantiGetir())
            {
                string query = "SELECT * FROM Kullanicilar";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    kullanicilar.Add(new Kullanici
                    {
                        KullaniciID = Convert.ToInt32(dr["KullaniciID"]),
                        KullaniciAdi = dr["KullaniciAdi"].ToString(),
                        Sifre = dr["Sifre"].ToString()
                    });
                }
            }
            return kullanicilar;
        }
    }
}

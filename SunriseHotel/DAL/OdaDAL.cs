using MySql.Data.MySqlClient;
using SunriseHotel.ENTITIES;
using System.Collections.Generic;
using System;


namespace SunriseHotel.DAL
{

    public class OdaDal
    {
        public void OdaEkle(Oda oda)
        {
            using (var connection = Baglanti.BaglantiGetir())
            {
                string query = "INSERT INTO Odalar (OdaNo, OdaDurumu, OdaTuru, OdaFiyati) VALUES (@p1, @p2, @p3, @p4)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@p1", oda.OdaNo);
                cmd.Parameters.AddWithValue("@p2", oda.OdaDurumu);
                cmd.Parameters.AddWithValue("@p3", oda.OdaTuru);
                cmd.Parameters.AddWithValue("@p4", oda.OdaFiyati);
                cmd.ExecuteNonQuery();
            }
        }

        public void OdaGuncelle(Oda oda)
        {
            using (var connection = Baglanti.BaglantiGetir())
            {
                string query = "UPDATE Odalar SET OdaNo=@p1, OdaDurumu=@p2, OdaTuru=@p3, OdaFiyati=@p4 WHERE OdaID=@p5";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@p1", oda.OdaNo);
                cmd.Parameters.AddWithValue("@p2", oda.OdaDurumu);
                cmd.Parameters.AddWithValue("@p3", oda.OdaTuru);
                cmd.Parameters.AddWithValue("@p4", oda.OdaFiyati);
                cmd.Parameters.AddWithValue("@p5", oda.OdaID);
                cmd.ExecuteNonQuery();
            }
        }

        public void OdaSil(Oda oda)
        {
            using (var connection = Baglanti.BaglantiGetir())
            {
                string query = "DELETE FROM Odalar WHERE OdaID=@p1";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@p1", oda.OdaID);
                cmd.ExecuteNonQuery();
            }
        }

        public List<Oda> OdaListele()
        {
            List<Oda> odalar = new List<Oda>();
            using (var connection = Baglanti.BaglantiGetir())
            {
                string query = "SELECT * FROM Odalar";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    odalar.Add(new Oda
                    {
                        OdaID = Convert.ToInt32(dr["OdaID"]),
                        OdaNo = dr["OdaNo"].ToString(),
                        OdaTuru = dr["OdaTuru"].ToString(),
                        OdaFiyati = Convert.ToDecimal(dr["OdaFiyati"]),
                        OdaDurumu = dr["OdaDurumu"].ToString()
                    });
                }
            }
            return odalar;
        }

        public bool OdaNoFarkli(string odaNo)
        {
            using (var connection = Baglanti.BaglantiGetir())
            {
                string query = "SELECT COUNT(*) FROM Odalar WHERE OdaNo=@p1";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@p1", odaNo);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count == 0;
            }
        }
    }
}



using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SunriseHotel.ENTITIES;


namespace SunriseHotel.DAL
    {
    public class RezervasyonDal
    {
        public void RezervasyonEkle(Rezervasyon rezervasyon)
        {
            using (var connection = Baglanti.BaglantiGetir())
            {
                string query = "INSERT INTO Rezervasyonlar (MusteriID, OdaID, HizmetID, BaslangicTarihi, BitisTarihi, KisiSayisi, SonFiyat) VALUES (@p1, @p2, @p3, @p4, @p5, @p6, @p7)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@p1", rezervasyon.MusteriID);
                cmd.Parameters.AddWithValue("@p2", rezervasyon.OdaID);
                cmd.Parameters.AddWithValue("@p3", rezervasyon.HizmetID);
                cmd.Parameters.AddWithValue("@p4", rezervasyon.BaslangicTarihi);
                cmd.Parameters.AddWithValue("@p5", rezervasyon.BitisTarihi);
                cmd.Parameters.AddWithValue("@p6", rezervasyon.KisiSayisi);
                cmd.Parameters.AddWithValue("@p7", rezervasyon.SonFiyat);
                cmd.ExecuteNonQuery();
            }
        }

        public void RezervasyonGuncelle(Rezervasyon rezervasyon)
        {
            using (var connection = Baglanti.BaglantiGetir())
            {
                string query = @"UPDATE Rezervasyonlar SET MusteriID=@p1, OdaID=@p2, HizmetID=@p3, 
                           BaslangicTarihi=@p4, BitisTarihi=@p5, KisiSayisi=@p6, SonFiyat=@p7 
                           WHERE RezervasyonID=@p8";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@p1", rezervasyon.MusteriID);
                cmd.Parameters.AddWithValue("@p2", rezervasyon.OdaID);
                cmd.Parameters.AddWithValue("@p3", rezervasyon.HizmetID);
                cmd.Parameters.AddWithValue("@p4", rezervasyon.BaslangicTarihi);
                cmd.Parameters.AddWithValue("@p5", rezervasyon.BitisTarihi);
                cmd.Parameters.AddWithValue("@p6", rezervasyon.KisiSayisi);
                cmd.Parameters.AddWithValue("@p7", rezervasyon.SonFiyat);
                cmd.Parameters.AddWithValue("@p8", rezervasyon.RezervasyonID);
                cmd.ExecuteNonQuery();
            }
        }

        public void RezervasyonSil(Rezervasyon rezervasyon)
        {
            using (var connection = Baglanti.BaglantiGetir())
            {
                string query = "DELETE FROM Rezervasyonlar WHERE RezervasyonID=@p1";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@p1", rezervasyon.RezervasyonID);
                cmd.ExecuteNonQuery();
            }
        }

        public List<Rezervasyon> RezervasyonListele()
        {
            List<Rezervasyon> rezervasyonlar = new List<Rezervasyon>();
            using (var connection = Baglanti.BaglantiGetir())
            {
                string query = "SELECT * FROM Rezervasyonlar";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    rezervasyonlar.Add(new Rezervasyon
                    {
                        RezervasyonID = Convert.ToInt32(dr["RezervasyonID"]),
                        MusteriID = Convert.ToInt32(dr["MusteriID"]),
                        OdaID = Convert.ToInt32(dr["OdaID"]),
                        HizmetID = Convert.ToInt32(dr["HizmetID"]),
                        BaslangicTarihi = Convert.ToDateTime(dr["BaslangicTarihi"]),
                        BitisTarihi = Convert.ToDateTime(dr["BitisTarihi"]),
                        KisiSayisi = Convert.ToInt32(dr["KisiSayisi"]),
                        SonFiyat = Convert.ToDecimal(dr["SonFiyat"])
                    });
                }
            }
            return rezervasyonlar;
        }

        public List<Oda> OdaDoluluk(DateTime baslangic, DateTime bitis)
        {
            List<Oda> musaitOdalar = new List<Oda>();
            using (var connection = Baglanti.BaglantiGetir())
            {
                string query = @"SELECT * FROM Odalar WHERE OdaID NOT IN 
                          (SELECT OdaID FROM Rezervasyonlar 
                           WHERE (BaslangicTarihi <= @p2 AND BitisTarihi >= @p1))";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@p1", baslangic);
                cmd.Parameters.AddWithValue("@p2", bitis);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    musaitOdalar.Add(new Oda
                    {
                        OdaID = Convert.ToInt32(dr["OdaID"]),
                        OdaNo = dr["OdaNo"].ToString(),
                        OdaDurumu = dr["OdaDurumu"].ToString(),
                        OdaTuru = dr["OdaTuru"].ToString(),
                        OdaFiyati = Convert.ToDecimal(dr["OdaFiyati"])
                    });
                }
            }
            return musaitOdalar;
        }

        public string FaturaGoruntule(int rezervasyonId)
        {
            using (var connection = Baglanti.BaglantiGetir())
            {
                string query = @"SELECT r.*, m.MusteriAd, m.MusteriSoyad, o.OdaNo, o.OdaFiyati, 
                         h.HizmetAd, h.HizmetFiyat
                         FROM Rezervasyonlar r
                         JOIN Musteriler m ON r.MusteriID = m.MusteriID
                         JOIN Odalar o ON r.OdaID = o.OdaID
                         JOIN Hizmetler h ON r.HizmetID = h.HizmetID
                         WHERE r.RezervasyonID = @p1";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@p1", rezervasyonId);

                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    return $@"
=== OTEL REZERVASYON FATURASI ===
Rezervasyon No: {dr["RezervasyonID"]}
Müşteri: {dr["MusteriAd"]} {dr["MusteriSoyad"]}
Oda No: {dr["OdaNo"]}
Alınan Hizmet: {dr["HizmetAd"]}
Giriş Tarihi: {Convert.ToDateTime(dr["BaslangicTarihi"]).ToShortDateString()}
Çıkış Tarihi: {Convert.ToDateTime(dr["BitisTarihi"]).ToShortDateString()}
Kişi Sayısı: {dr["KisiSayisi"]}
Toplam Tutar: {dr["SonFiyat"]:C2}
================================";
                }
                return "Fatura bulunamadı.";
            }
        }

        public decimal SonTutarHesapla(int odaId, int hizmetId, DateTime baslangic, DateTime bitis, int kisiSayisi)
        {
            using (var connection = Baglanti.BaglantiGetir())
            {
                string query = @"SELECT ((o.OdaFiyati + h.HizmetFiyat) * @p5) * DATEDIFF(@p3, @p4) as ToplamTutar
                           FROM Odalar o, Hizmetler h 
                           WHERE o.OdaID = @p1 AND h.HizmetID = @p2";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@p1", odaId);
                cmd.Parameters.AddWithValue("@p2", hizmetId);
                cmd.Parameters.AddWithValue("@p3", bitis);
                cmd.Parameters.AddWithValue("@p4", baslangic);
                cmd.Parameters.AddWithValue("@p5", kisiSayisi);

                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    return Convert.ToDecimal(result);
                }
                return 0;
            }
        }
    }
}




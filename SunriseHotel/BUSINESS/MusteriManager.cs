using SunriseHotel.DAL;
using SunriseHotel.ENTITIES;
using System.Collections.Generic;
using System;

namespace SunriseHotel.BUSINESS
{
    public class MusteriManager
    {
        private readonly MusteriDal _musteriDal;

        public MusteriManager()
        {
            _musteriDal = new MusteriDal();
        }

        public void MusteriEkle(Musteri musteri)
        {
            if (string.IsNullOrEmpty(musteri.MusteriAd))
                throw new ArgumentException("Müşteri adı boş olamaz.");
            if (string.IsNullOrEmpty(musteri.MusteriSoyad))
                throw new ArgumentException("Müşteri soyadı boş olamaz.");
            if (string.IsNullOrEmpty(musteri.TcKimlik) || musteri.TcKimlik.Length != 11)
                throw new ArgumentException("TC Kimlik numarası 11 haneli olmalıdır.");
            if (!_musteriDal.TcKimlikFarkli(musteri.TcKimlik))
                throw new ArgumentException("Bu TC Kimlik numarası zaten kayıtlı.");

            _musteriDal.MusteriEkle(musteri);
        }

        public void MusteriGuncelle(Musteri musteri)
        {
            if (string.IsNullOrEmpty(musteri.MusteriAd))
                throw new ArgumentException("Müşteri adı boş olamaz.");
            if (string.IsNullOrEmpty(musteri.MusteriSoyad))
                throw new ArgumentException("Müşteri soyadı boş olamaz.");
            if (string.IsNullOrEmpty(musteri.TcKimlik) || musteri.TcKimlik.Length != 11)
                throw new ArgumentException("TC Kimlik numarası 11 haneli olmalıdır.");

            _musteriDal.MusteriGuncelle(musteri);
        }

        public void MusteriSil(Musteri musteri)
        {
            _musteriDal.MusteriSil(musteri);
        }

        public List<Musteri> MusteriListele()
        {
            return _musteriDal.MusteriListele();
        }
    }
}

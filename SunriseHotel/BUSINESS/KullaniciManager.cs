using SunriseHotel.DAL;
using SunriseHotel.ENTITIES;
using System.Collections.Generic;
using System;

namespace SunriseHotel.BUSINESS
{
    public class KullaniciManager
    {
        private readonly KullaniciDal _kullaniciDal;

        public KullaniciManager()
        {
            _kullaniciDal = new KullaniciDal();
        }

        public void KullaniciEkle(Kullanici kullanici)
        {
            if (string.IsNullOrEmpty(kullanici.KullaniciAdi))
                throw new ArgumentException("Kullanıcı adı boş olamaz.");
            if (string.IsNullOrEmpty(kullanici.Sifre))
                throw new ArgumentException("Şifre boş olamaz.");
            if (kullanici.Sifre.Length < 6)
                throw new ArgumentException("Şifre en az 6 karakter olmalıdır.");

            _kullaniciDal.KullaniciEkle(kullanici);
        }

        public void KullaniciGuncelle(Kullanici kullanici)
        {
            if (string.IsNullOrEmpty(kullanici.KullaniciAdi))
                throw new ArgumentException("Kullanıcı adı boş olamaz.");
            if (string.IsNullOrEmpty(kullanici.Sifre))
                throw new ArgumentException("Şifre boş olamaz.");
            if (kullanici.Sifre.Length < 6)
                throw new ArgumentException("Şifre en az 6 karakter olmalıdır.");

            _kullaniciDal.KullaniciGuncelle(kullanici);
        }

        public void KullaniciSil(Kullanici kullanici)
        {
            _kullaniciDal.KullaniciSil(kullanici);
        }

        public List<Kullanici> KullaniciListele()
        {
            return _kullaniciDal.KullaniciListele();
        }
    }

}


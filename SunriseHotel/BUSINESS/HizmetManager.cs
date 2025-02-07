using SunriseHotel.DAL;
using SunriseHotel.ENTITIES;
using System.Collections.Generic;
using System;

namespace SunriseHotel.BUSINESS
{
    public class HizmetManager
    {
        private readonly HizmetDal _hizmetDal;

        public HizmetManager()
        {
            _hizmetDal = new HizmetDal();
        }

        public void HizmetEkle(Hizmet hizmet)
        {
            if (string.IsNullOrEmpty(hizmet.HizmetAd))
                throw new ArgumentException("Hizmet adı boş olamaz.");
            if (hizmet.HizmetFiyat <= 0)
                throw new ArgumentException("Hizmet fiyatı 0'dan büyük olmalıdır.");

            _hizmetDal.HizmetEkle(hizmet);
        }

        public void HizmetGuncelle(Hizmet hizmet)
        {
            if (string.IsNullOrEmpty(hizmet.HizmetAd))
                throw new ArgumentException("Hizmet adı boş olamaz.");
            if (hizmet.HizmetFiyat <= 0)
                throw new ArgumentException("Hizmet fiyatı 0'dan büyük olmalıdır.");

            _hizmetDal.HizmetGuncelle(hizmet);
        }

        public void HizmetSil(Hizmet hizmet)
        {
            _hizmetDal.HizmetSil(hizmet);
        }

        public List<Hizmet> HizmetListele()
        {
            return _hizmetDal.HizmetListele();
        }
    }
}

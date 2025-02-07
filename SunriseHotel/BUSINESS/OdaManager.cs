using System;
using System.Collections.Generic;
using SunriseHotel.DAL;
using SunriseHotel.ENTITIES;

namespace SunriseHotel.BUSINESS
{


    public class OdaManager
    {
        private readonly OdaDal _odaDal;

        public OdaManager()
        {
            _odaDal = new OdaDal();
        }

        public void OdaEkle(Oda oda)
        {
            if (string.IsNullOrEmpty(oda.OdaNo))
                throw new ArgumentException("Oda numarası boş olamaz.");
            if (string.IsNullOrEmpty(oda.OdaTuru))
                throw new ArgumentException("Oda türü boş olamaz.");
            if (oda.OdaFiyati <= 0)
                throw new ArgumentException("Oda fiyatı 0'dan büyük olmalıdır.");
            if (!_odaDal.OdaNoFarkli(oda.OdaNo))
                throw new ArgumentException("Bu oda numarası zaten mevcut.");

            _odaDal.OdaEkle(oda);
        }

        public void OdaGuncelle(Oda oda)
        {
            if (string.IsNullOrEmpty(oda.OdaNo))
                throw new ArgumentException("Oda numarası boş olamaz.");
            if (string.IsNullOrEmpty(oda.OdaTuru))
                throw new ArgumentException("Oda türü boş olamaz.");
            if (oda.OdaFiyati <= 0)
                throw new ArgumentException("Oda fiyatı 0'dan büyük olmalıdır.");

            _odaDal.OdaGuncelle(oda);
        }

        public void OdaSil(Oda oda)
        {
            _odaDal.OdaSil(oda);
        }

        public List<Oda> OdaListele()
        {
            return _odaDal.OdaListele();
        }
    }
}




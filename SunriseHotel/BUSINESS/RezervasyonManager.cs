using System;
using SunriseHotel.DAL;
using SunriseHotel.ENTITIES;
using System.Collections.Generic;
using System.Linq;

namespace SunriseHotel.BUSINESS
{
    public class RezervasyonManager
    {
        private readonly RezervasyonDal _rezervasyonDal;
        private readonly OdaDal _odaDal;
        private readonly HizmetDal _hizmetDal;

        public RezervasyonManager()
        {
            _rezervasyonDal = new RezervasyonDal();
            _rezervasyonDal = new RezervasyonDal();
            _odaDal = new OdaDal();
            _hizmetDal = new HizmetDal();
        }

        public void RezervasyonEkle(Rezervasyon rezervasyon)
        {
            if (rezervasyon.BaslangicTarihi >= rezervasyon.BitisTarihi)
                throw new ArgumentException("Başlangıç tarihi bitiş tarihinden önce olmalıdır.");
            if (rezervasyon.KisiSayisi <= 0)
                throw new ArgumentException("Kişi sayısı 0'dan büyük olmalıdır.");
            if (rezervasyon.BaslangicTarihi < DateTime.Today)
                throw new ArgumentException("Geçmiş tarihli rezervasyon yapılamaz.");

            // Oda müsaitlik kontrolü
            var musaitOdalar = _rezervasyonDal.OdaDoluluk(rezervasyon.BaslangicTarihi, rezervasyon.BitisTarihi);
            if (!musaitOdalar.Any(o => o.OdaID == rezervasyon.OdaID))
                throw new ArgumentException("Seçilen oda bu tarihler için müsait değil.");

            // Son tutar hesaplama
            rezervasyon.SonFiyat = _rezervasyonDal.SonTutarHesapla(
                rezervasyon.OdaID,
                rezervasyon.HizmetID,
                rezervasyon.BaslangicTarihi,
                rezervasyon.BitisTarihi,
                rezervasyon.KisiSayisi
            );

            _rezervasyonDal.RezervasyonEkle(rezervasyon);
        }

        public void RezervasyonGuncelle(Rezervasyon rezervasyon)
        {
            if (rezervasyon.BaslangicTarihi >= rezervasyon.BitisTarihi)
                throw new ArgumentException("Başlangıç tarihi bitiş tarihinden önce olmalıdır.");
            if (rezervasyon.KisiSayisi <= 0)
                throw new ArgumentException("Kişi sayısı 0'dan büyük olmalıdır.");

            // Son tutar güncelleme
            rezervasyon.SonFiyat = _rezervasyonDal.SonTutarHesapla(
                rezervasyon.OdaID,
                rezervasyon.HizmetID,
                rezervasyon.BaslangicTarihi,
                rezervasyon.BitisTarihi,
                rezervasyon.KisiSayisi
            );

            _rezervasyonDal.RezervasyonGuncelle(rezervasyon);
        }

        public void RezervasyonSil(Rezervasyon rezervasyon)
        {
            _rezervasyonDal.RezervasyonSil(rezervasyon);
        }

        public List<Rezervasyon> RezervasyonListele()
        {
            return _rezervasyonDal.RezervasyonListele();
        }

        public List<Oda> MusaitOdalariListele(DateTime baslangic, DateTime bitis)
        {
            if (baslangic >= bitis)
                throw new ArgumentException("Başlangıç tarihi bitiş tarihinden önce olmalıdır.");
            if (baslangic < DateTime.Today)
                throw new ArgumentException("Geçmiş tarihli sorgulama yapılamaz.");

            return _rezervasyonDal.OdaDoluluk(baslangic, bitis);
        }

        public string FaturaGoruntule(int rezervasyonId)
        {
            return _rezervasyonDal.FaturaGoruntule(rezervasyonId);
        }

        public decimal SonTutarHesapla(int odaId, int hizmetId, DateTime baslangic, DateTime bitis, int kisiSayisi)
        {
            if (baslangic >= bitis)
                throw new ArgumentException("Başlangıç tarihi bitiş tarihinden önce olmalıdır.");
            if (kisiSayisi <= 0)
                throw new ArgumentException("Kişi sayısı 0'dan büyük olmalıdır.");

            return _rezervasyonDal.SonTutarHesapla(odaId, hizmetId, baslangic, bitis, kisiSayisi);
        }
    }
}

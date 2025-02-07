using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunriseHotel.ENTITIES
{
    public class Musteri
    {
        public int MusteriID { get; set; }
        public string MusteriAd { get; set; }
        public string MusteriSoyad { get; set; }
        public string TcKimlik { get; set; }
        public string MusteriTelNo { get; set; }

        public string MusteriAdSoyad => $"{MusteriAd} {MusteriSoyad}";
    }
}

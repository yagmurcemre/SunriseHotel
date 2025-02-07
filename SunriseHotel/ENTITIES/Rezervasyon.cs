using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SunriseHotel.ENTITIES
{
    public class Rezervasyon
    {
        public int RezervasyonID { get; set; }
        public int MusteriID { get; set; }
        public int OdaID { get; set; }
        public int HizmetID { get; set; }
        public DateTime BaslangicTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }
        public int KisiSayisi { get; set; }
        public decimal SonFiyat { get; set; }
    }
}


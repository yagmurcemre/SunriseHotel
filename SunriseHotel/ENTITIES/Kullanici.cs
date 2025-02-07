using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SunriseHotel.ENTITIES
{
    
        public class Kullanici
        {
            public int KullaniciID { get; set; }
            public string KullaniciAdi { get; set; } 
            public string Sifre { get; set; } 
        }
    }




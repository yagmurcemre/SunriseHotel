using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SunriseHotel.ENTITIES
{
    public class Oda
    {
        public int OdaID { get; set; }
        public string OdaNo { get; set; }
        public string OdaDurumu { get; set; }
        public string OdaTuru { get; set; }
        public decimal OdaFiyati { get; set; }
    }

}

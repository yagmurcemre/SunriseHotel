using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SunriseHotel.DAL
{
    public class Baglanti
    {
        public static MySqlConnection BaglantiGetir()
        {
            MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.253; Database=25_132330012; Uid=25_132330012; Pwd=!nif.ogr12YA");
            baglanti.Open(); 
            return baglanti;


        }
    }

     
}
    

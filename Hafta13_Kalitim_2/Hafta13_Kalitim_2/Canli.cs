using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Canlı sınıfı tüm canlılarda ortak bulunan özellikleri tanımlar
namespace Hafta13_Kalitim_2
{
    public class Canli
    {
        //her canlının adı vardır
        public string Ad { get; set; }
        //her canlı solunum yapar
        public string Solunum { get; set; }
        //her canlı beslenmek zorundadır
        public string Beslenme { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta13_Golgeleme
{
    public class OkulPersoneli
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public double Maas { get; set; }

        public void MaasHesapla()
        {
            double hesapla = Maas + Maas * 0.18;
            Console.WriteLine("Personel Maaşı:" + hesapla);
        }
    }

    public class Ogretmen : OkulPersoneli
    {
        public string Brans { get; set; }
    }

    public class Idare : OkulPersoneli
    {
        public new void MaasHesapla()
        {
            double hesapla = Maas + Maas * 0.20;
            Console.WriteLine("Personel Maaşı:" + hesapla);
        }

    }

    public class Program
    {
        static void Main(string[] args)
        {
            Ogretmen ogr = new Ogretmen
            {
                Ad = "Ayhan",
                Soyad = "Akkaya",
                Brans="Bilişim",
                Maas = 20000.0
            };
            Console.WriteLine("Personel Adı:" + ogr.Ad);
            Console.WriteLine("Personel Soyadı:" + ogr.Soyad);
            Console.WriteLine("Personel Branşı:" + ogr.Brans);
            Console.WriteLine("Personel Normal Maaşı:" + ogr.Maas);
            ogr.MaasHesapla();
            Console.WriteLine("*******************");

            Idare mudur = new Idare
            {
                Ad = "İrfan",
                Soyad = "Sürücü",
                Maas = 20000.0
            };
            Console.WriteLine("Personel Adı:" + mudur.Ad);
            Console.WriteLine("Personel Soyadı:" + mudur.Soyad);
            Console.WriteLine("Personel Normal Maaşı:" + mudur.Maas);
            mudur.MaasHesapla();
            Console.WriteLine("*******************");
            Console.ReadKey();


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta13_Kalitim_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Kus kus1 = new Kus
            {
                Ad="Papağan",
                AyakSayisi=2,
                Beslenme="Gaga",
                Kanat=true,
                Solunum="Akciger",
                Tur="Evcil"
            };

            Console.WriteLine("Kuş Adı : " + kus1.Ad);
            Console.WriteLine("Kuş AyakSayisi : " + kus1.AyakSayisi);
            Console.WriteLine("Kuş Beslenme Türü : " + kus1.Beslenme);
            Console.WriteLine("Kuş Kanat Sayısı : " + kus1.Kanat);
            Console.WriteLine("Kuş Solunum Türü : " + kus1.Solunum);
            Console.WriteLine("Kuş Türü : " + kus1.Tur);
            Console.WriteLine("**********************");


            Balik balik1 = new Balik
            {
                Ad="Hamsi",
                Beslenme="Ağız",
                Kanat=false,
                Solunum="Solungaç"
         
            };

            Console.WriteLine("Balık Adı:" + balik1.Ad);
            Console.WriteLine("Balık Beslenme Şekli:" + balik1.Beslenme);
            Console.WriteLine("Balık Kanat Var mı:" + balik1.Kanat);
            Console.WriteLine("Balık Solunum Türü:" + balik1.Solunum);
            Console.ReadKey();
        }
    }
}

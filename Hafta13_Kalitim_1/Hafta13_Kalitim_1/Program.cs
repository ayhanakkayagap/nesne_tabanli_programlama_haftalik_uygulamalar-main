using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta13_Kalitim_1
{

    public class OkulPersoneli
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
    }

    public class Ogretmen : OkulPersoneli
    {
        public string Brans { get; set; }
    }

    public class Idare : OkulPersoneli
    {
        public string Gorev { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Ogretmen ogr = new Ogretmen
            {
                Ad = "Ahmet",
                Soyad="Öz",
                Brans="Matematik"
            };
            Console.WriteLine("Öğretmen Adı:"+ogr.Ad);
            Console.WriteLine("Öğretmen Soyadı:" + ogr.Soyad);
            Console.WriteLine("Öğretmen Branşı:" + ogr.Brans);
            Console.WriteLine("***********");
            // OkulPersoneli per = ogr;
            //Console.WriteLine(per.Ad);
            Idare idare = new Idare
            {
                Ad = "Mehmet",
                Soyad = "Kaya",
                Gorev="Müdür"
               
            };
            Console.WriteLine("İdare Adı:" + idare.Ad);
            Console.WriteLine("idare Soyadı:" + idare.Soyad);
            Console.WriteLine("İdare Görevi :" + idare.Gorev);
            Console.WriteLine("***********");

            Console.ReadKey();
            

        }
    }

    




}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using ile başlayan kodlar kütüphanelerdir.
namespace Hafta12_Genel_Tekrar
{
    class Program
    {
        //main metodu ana metottur.
        static void Main(string[] args)
        {
            Console.WriteLine("Main metodu çalıştı");
            Personel mudur = new Personel("irfan",40000,"Müdür");
            Console.WriteLine(mudur.personelGorev+" Adı :"+mudur.personelAd);
            Console.WriteLine(mudur.personelGorev + " Maaş :" + mudur.personelMaas);
            Console.WriteLine(mudur.personelGorev + " Görevi :" + mudur.personelGorev);
            Console.WriteLine(mudur.personelGorev + " ün yeni maaşı=" + mudur.zam(0.2,40000));
            Console.WriteLine("*****************************************");
            Personel teknik = new Personel("ayhan",20000, "Teknik Personel");
            Console.WriteLine(teknik.personelGorev + "  ün Adı :" + teknik.personelAd);
            Console.WriteLine(teknik.personelGorev + "  ün Maaşı :" + teknik.personelMaas);
            Console.WriteLine(teknik.personelGorev + " ün Görevi :" + teknik.personelGorev);
            Console.WriteLine(teknik.personelGorev + " ün yeni maaşı=" + teknik.zam(0.2, 20000));

            Console.ReadKey();
        }
    }
}

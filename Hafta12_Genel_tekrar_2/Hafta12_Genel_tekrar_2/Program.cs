using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta12_Genel_tekrar_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********Gelir-Gider Takip Programı***********");
            Console.Write("Gelir Adını Yazınız:");
            string gelirAdi = Console.ReadLine();
            Console.Write("Maaş Tutarını Yazınız:");
            int gelirtutar = Convert.ToInt32(Console.ReadLine());
            Console.Write("Gider Tipini Yazınız:");
            string kira = Console.ReadLine();
            Console.Write("Gider Tutarını Yazınız:");
            int kiraTutar = Convert.ToInt32(Console.ReadLine());
            Console.Write("Gider Tipini Yazınız:");
            string faturalar = Console.ReadLine();
            Console.Write("Gider Tutarını Yazınız:");
            int faturaTutar = Convert.ToInt32(Console.ReadLine());
            Console.Write("Gider Tipini Yazınız:");
            string mutfak = Console.ReadLine();
            Console.Write("Gider Tutarını Yazınız:");
            int mutfakTutar = Convert.ToInt32(Console.ReadLine());
            int toplamGider = kiraTutar+faturaTutar+mutfakTutar;
            int birikim = gelirtutar-toplamGider;
            if (birikim > 0)
            {
                Console.WriteLine("Toplam Birikiminiz :" + birikim);

            }

            else
            {
                Console.WriteLine("Hapı yuttun");
            }

            
            Console.Write("Ay sayısını giriniz:");
            int aySayisi = Convert.ToInt32(Console.ReadLine());
            int toplamBirikim = aySayisi * birikim;
            Console.WriteLine(aySayisi + " aylık toplam birikim="+toplamBirikim);
            
            Console.ReadKey();



        }
    }
}

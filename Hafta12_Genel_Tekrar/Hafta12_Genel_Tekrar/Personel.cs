using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta12_Genel_Tekrar
{
    public class Personel
    {
        public string personelAd;
        public int personelMaas;
        public string personelGorev;

       public Personel(string personelAd,int personelMaas,string personelGorev)
        {
            this.personelAd = personelAd;
            this.personelMaas = personelMaas;
            this.personelGorev = personelGorev;
            Console.WriteLine("Personel sınıfı çalıştı");
        }

        public string Ad()
        {
            return personelAd;
        }

        public int Maas()
        {
            return personelMaas;
        }

        public string Gorev()
        {
            return personelGorev;
        }

        public double zam(double zamOrani,double yeniMaas)
        {
            double zam = personelMaas * zamOrani + personelMaas;


            return zam;
        }

        



    }
}

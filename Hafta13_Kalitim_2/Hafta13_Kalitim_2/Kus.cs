using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta13_Kalitim_2
{
    //Bu sınıfta sadece kuşlarda olan özellikleri yazalım
    public class Kus : Hayvanlar
    {
        // Bu tanımla Hayvanlar sınıfının 
        //tüm özellikleri kus sınıfında tanımlanmıştır
        //Yani Hayvanın adı,solunum,beslenme,ayakSayisi,kanat, özellikleri canli sınıfından gelmiştir.
        public string Tur { get; set; }

    }
}

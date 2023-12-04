using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta13_Kalitim_2
{
    //Bu sınıfta sadece hayvanlarda olan özellikleri yazalım
   public  class Hayvanlar : Canli // Bu tanımla Canli sınıfının 
        //tüm özellikleri hayvan sınıfında tanımlanmıştır
        //Yani Hayvanın adı,solunum,beslenme özellikleri canli sınıfından gelmiştir.
    {
        public int AyakSayisi { get; set; }
        public bool Kanat { get; set; }

    }
}

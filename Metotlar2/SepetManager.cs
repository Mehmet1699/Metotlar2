using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar2
{
     class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi : " + urun.Adi);

        }
        public void Ekle2(string urunadi, string aciklama, double fiyat,int stokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi : " + urunadi);
            Console.WriteLine("Tebrikler. Sepete Eklendi : " + aciklama);
            Console.WriteLine("Tebrikler. Sepete Eklendi : " + fiyat);
        }
        

    }
}

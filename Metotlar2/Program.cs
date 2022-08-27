using Metotlar2;
using System;
// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main(string[] args)
    {
        string urunAdi = "Elma";
        double fiyat = 15;
        string Aciklama = "Amasya Elması";

        string[] meyveler = new string[] { "Elma", "Karpuz" };

        Urun urun1 = new Urun();
        urun1.Adi = "Elma";
        urun1.Fiyati = 15;
        urun1.Aciklama = "Amasya Elması";

        Urun urun2 = new Urun();
        urun2.Adi = "Karpuz";
        urun2.Fiyati = 80;
        urun2.Aciklama = "Diyarbakır Karpuzu";

        Urun[] urunler = new Urun[] { urun1, urun2 };

        foreach (var urun in urunler)
        {
            Console.WriteLine(urun.Adi);
            Console.WriteLine(urun.Fiyati);
            Console.WriteLine(urun.Aciklama);
            Console.WriteLine("-------------");
        }


        Console.WriteLine("------Metotlar------");

        SepetManager sepetmanager = new SepetManager();
        sepetmanager.Ekle(urun1);
        sepetmanager.Ekle(urun2);

        sepetmanager.Ekle2("Armut", "Yeşil Armut", 12, 7);
        sepetmanager.Ekle2("Elma", "Golden", 12, 9);
        sepetmanager.Ekle2("Karpuz", "Diyarbakır", 12, 5);


    }
}
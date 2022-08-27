// See https://aka.ms/new-console-template for more information
using _7KomdTug;

Console.WriteLine("Hello, World!");

Amir amir1 = new Amir();
amir1.Soyadi = "Ercan";
amir1.Rutbesi = "Albay";
amir1.Sinifi = "Topcu";
amir1.BagliPersonel = 4;


Amir amir2 = new Amir();
amir2.Soyadi = "Cetin";
amir2.Rutbesi = "ütğm";
amir2.Sinifi = "Tankcı";
amir2.BagliPersonel = 3;

Amir[] amirler = new Amir[]{amir1,amir2};
foreach (var amir in amirler)
{
    Console.WriteLine(amir.Sinifi+ " "+amir.Rutbesi+" "+amir.Soyadi+
        " Amirine bağlı personel sayısı: "+amir.BagliPersonel);
}

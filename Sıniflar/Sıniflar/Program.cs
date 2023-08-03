using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sıniflar
{
    class Program
    {
        static void Main(string[] args)
        {
            Araba ar = new Araba();
            ar.marka = "Marka X";
            ar.hiz = 180;
            ar.model = "2021";
            ar.motor = 1.6;
            ar.renk = "Siyah";

            Console.Write("***** Araba Tanıtım *****");
            Console.WriteLine();
            Console.WriteLine("Marka: " + ar.marka);
            Console.WriteLine("Hız: " + ar.hiz);
            Console.WriteLine("Model: " + ar.model);
            Console.WriteLine("Motor Gücü: " + ar.motor);
            Console.WriteLine("Renk: " + ar.renk);
            Console.WriteLine();


            Musteri mus = new Musteri();
            mus.ID = 1;
            mus.AdSoyad = "Mert Söylemez";
            mus.Sehir = "İstanbul";

            Console.Write("***** Müşteri Bilgisi *****");
            Console.WriteLine();
            Console.WriteLine("ID: " + mus.ID);
            Console.WriteLine("Ad Soyad: " + mus.AdSoyad);
            Console.WriteLine("Şehir: " + mus.Sehir);
            Console.WriteLine();

            mus.ID = 2;
            mus.AdSoyad = "Polat Kara";
            mus.Sehir = "Ankara";

            Console.Write("***** Müşteri Bilgisi *****");
            Console.WriteLine();
            Console.WriteLine("ID : " + mus.ID + " Ad Soyad: " + mus.AdSoyad + " Şehir: " + mus.Sehir);
            
            Musteri musteri = new Musteri();
            Console.Write("ID girin: ");
            musteri.ID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ad Soyad girin: ");
            musteri.AdSoyad = Console.ReadLine();
            Console.Write("Şehri girin: ");
            musteri.Sehir = Console.ReadLine();

            Console.WriteLine("******* Müşteri Kimlik Kartı *******");
            Console.WriteLine();
            Console.WriteLine("ID: "+ musteri.ID + " Ad Soyad: " + musteri.AdSoyad + " Şehir: " + musteri.Sehir);
            

            //Kalıtım

            papagan p = new papagan();
            p.tur = "Papağan";
            p.hiz = 50;
            p.isim = "Sultan";
            p.renk = "Sarı-Kırmızı";
            p.agirlik = 1650;
            p.sescikar();

            Console.WriteLine("İsim: " + p.isim);
            Console.WriteLine("Tür: " + p.tur);
            Console.WriteLine("Hız: " + p.hiz);
            Console.WriteLine("Ağırlık: " + p.agirlik);
            Console.WriteLine("Renk: " + p.renk);
            Console.WriteLine("Ses: " + p.sescikar());
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("***************");
            Karga k = new Karga();
            k.agirlik = 1350;
            k.hiz = 80;
            k.renk = "siyah";
            k.isim = "Alacakarga";
            k.tur = "Karga";
            k.sescikar();

            Console.WriteLine("İsim: " + k.isim);
            Console.WriteLine("Tür: " + k.tur);
            Console.WriteLine("Hız: " + k.hiz);
            Console.WriteLine("Ağırlık: " + k.agirlik);
            Console.WriteLine("Renk: " + k.renk);
            Console.WriteLine("Ses: " + k.sescikar());
            Console.WriteLine();









            Console.Read();
        }
    }
}

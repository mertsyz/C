using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class Program
    {

         public static void yazdir()
        {
            Console.Write("Bu bir metottur");
            Console.WriteLine();
            Console.Write("Burası metodun bir başka satırıdır");
            Console.WriteLine();
        }

        public static void toplama()
        {
            int sayi1 = 24, sayi2 = 23;
            int toplam = sayi1 + sayi2;
            Console.Write(toplam);
        }
        public static void yazıbosluk()
        {
            Console.WriteLine();
            Console.Write("**************");
            Console.WriteLine();
        }
        public static void ardisiksayilar()
        {
            for(int i = 1; i < 11; i++)
            {
                Console.Write(i + " ");
            }
        }

        public static void metinyaz(string p)
        {
            Console.Write("**********");
            Console.WriteLine();
            Console.Write(p);
            Console.WriteLine();
            Console.Write("**********");
            Console.WriteLine();
        }

        public static void metinyaz2(string parametre)
        {
            Console.Write("----------------");
            Console.WriteLine();
            Console.Write(parametre);
            Console.WriteLine();
            Console.Write("----------------");
        } 

        public static int toplama()
        {
            int sayi1, sayi2, sonuc;
            sayi1 = 25;
            sayi2 = 20;
            sonuc = sayi1 + sayi2;
            return sonuc;

        }

        public static int toplam(int s1, int s2)
        {
            int sonuc;
            sonuc = s1 + s2;
            return sonuc;
        }

        public static int ortalama(int sinav1, int sinav2)
        {
            int sonuc = (sinav1 + sinav2) / 2;
            return sonuc;
        }
        public static int ortalama(int sinav1, int sinav2, int sinav3)
        {
            int sonuc = (sinav1 + sinav2 + sinav3) / 2;
            return sonuc;
        }

        static void Main(string[] args)
        {
             yazdir();
            yazıbosluk();
            yazdir();
            yazıbosluk();
            toplama();
            yazıbosluk();
            ardisiksayilar(); 


            Console.Write("Kelimeyi Girin: ");
            string kelime = Console.ReadLine();
            metinyaz("Hello World!");
            metinyaz2(kelime); 

            Console.Write(toplama());

            Console.Write("Toplam: " + toplam(10, 100));

            int sayi1, sayi2;
            Console.Write("1. Sayıyı Girin: ");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Sayıyı Girin: ");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sonuç: " + toplam(sayi1, sayi2));
            Console.Write(toplam(7, 8));

            Console.WriteLine("Ortalama: " + ortalama(75, 34));
            Console.Write("Ortalama: " + ortalama(54, 23, 64));
            




            Console.Read();
        }
    }
}

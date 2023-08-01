using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] sehirler = { "İstanbul", "Ankara", "İzmir" };
            Console.WriteLine(sehirler[2]);
            Console.WriteLine(sehirler[1]); 

            int[] sayilar = { 10, 20, 30, 50, 100 };
            Console.WriteLine(sayilar[4]);

            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine(sayilar[i]);
            }  

            int[] sayilar = { 10, 20, 30, 50, 60, 70, 80, 90 };
            for ( int i = 0; i < sayilar.Length; i++ )
            {
                if(sayilar[i] %20 == 0 && sayilar[i] %30 == 0)
                {
                    Console.WriteLine(sayilar[i]);
                }
                
            } 

            string[] kisiler = { "ali", "veli", "mert", "eylül" };
            for(int i = 0; i < kisiler.Length; i++)
            {
                Console.WriteLine(kisiler[i]);
            }  

            int[] sayilar = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            int toplam = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                toplam += sayilar[i];
                
            }
            Console.WriteLine(toplam); 

            int[] sayilar = { 10, 43, 23, 74, 27, 90, 345 };
            Array.Sort(sayilar);
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);
            } 

            string[] sehirler = { "Adana", "Ankara", "Mersin", "Bursa" };
            Array.Reverse(sehirler);
            for (int i = 0; i< sehirler.Length; i++)
            {
                Console.WriteLine(sehirler[i]);
            }
            

            string[] kisiler = { "Mert", "Buse", "Hakan", "Melih" };
            int sira;
            Array.Sort(kisiler);
            sira = Array.IndexOf(kisiler, "Hakan");
            Console.Write(sira); 

            int[] sayilar = { 50, 23, 85, 34, 2124, 434, 656, 22 };
            Console.Write(sayilar.Max());
            Console.Write(sayilar.Min()); 


            string[] sehirler = { "İstanbul", "Adana", "Ankara", "İzmir" };
            foreach(string i in sehirler)
            {
                Console.WriteLine(i);
            } 

            int[] sayilar = { 23, 55, 76, 34, 89, 45 };
            int toplam = 0;
            foreach(int i in sayilar)
            {
                toplam = toplam + i;
            }
            Console.WriteLine(toplam); 

            int[] sayilar = { 1, 53, 745, 35, 78, 45, 454, 86 };
            Array.Sort(sayilar);
            foreach (int i in sayilar)
            {
                if (i % 2 == 0)
                {
                    
                    Console.WriteLine(i);
                }
            } 

            string[] sehirler = new string[5];
            for (int i = 0; i<5; i++)
            {
                Console.Write("Şehir İsmi: ");
                sehirler[i] = Console.ReadLine();
            }
            for(int j= 0; j < 5; j++)
            {
                Console.WriteLine(sehirler[j]);
            }

          Console.Read();
        }
    }
}

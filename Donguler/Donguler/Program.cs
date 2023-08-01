using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            for(i= 1; i <= 10; i++)
            {
                Console.WriteLine("Hello World!");
                
            } 

            int i;

            for (i = 1; i<11; i++)
            {
                Console.WriteLine(i);
            } 

            int i;
            for (i=0; i <= 20; i += 2)
            {
                Console.WriteLine(i);
            } 

            int k;
            for (k = 1; k<= 100; k += 1)
            {
                Console.WriteLine(k + " Merhaba İstanbul");
            } 

            int sayi;
            Console.Write("Sayıyı Girin: ");
            sayi = Convert.ToInt32(Console.ReadLine());

            if(sayi % 2 == 0)
            {
                Console.Write("Sayı Çift.");
            }
            else
            {
                Console.Write("Sayı Tek.");
            }
            


            for (int i = 1; i<= 20; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            

            int sayi;
            Console.Write("Sayıyı Girin: ");
            sayi = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= sayi; i++)
            {
                if (sayi % i == 0)
                {
                    Console.WriteLine(i);
                }
            } 

            int bakteri = 1;
            for (int i = 1; i<= 24; i++)
            {
                bakteri = bakteri * 2;
            }
            Console.Write(bakteri); 


            int toplam = 0;
            for (int i = 1; i <= 10; i++)
            {
                toplam = toplam + i;

            }
            Console.Write(toplam); 

            Console.Write("Sayı Girin: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int faktoriyel = 1;
            for (int i = 1; i<= sayi; i++)
            {
                faktoriyel = faktoriyel * i;
            }
            Console.Write(faktoriyel); 


            int sayac = 1;
            while(sayac < 10)
            {
                Console.WriteLine("Hello World");
                sayac += 1;
            }
            Console.WriteLine(sayac); 

            int sayi = 1;
            while (sayi <= 20)
            {
                Console.WriteLine(sayi);
                sayi += 1;
            } 

            int sayi = 1;
            int toplam = 0;
            while( sayi <= 10)
            {
                toplam = toplam + sayi;
                sayi++;
            }
            Console.Write(toplam); 

            Console.Write("Sayıyı Girin: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int faktoriyel = 1;
            while (sayi >= 1)
            {
                faktoriyel = faktoriyel * sayi;
                sayi--;
            }
            Console.WriteLine(faktoriyel); 

            int sayi = 11;
            do
            {
                
                Console.WriteLine(sayi);
                sayi++;
            }
            while (sayi <= 10);


            Console.Read();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karar_Yapilari
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Şehir Adı: ");
            string sehir = Console.ReadLine();
            if (sehir=="adana")
            {
                Console.Write("Doğru Şehir!");
            }
            else
            {
                Console.Write("Yanlış Şehir!");
            }
            Console.Read(); 

            int sayi;
            Console.Write("Sayıyı Giriniz: ");
            sayi = Convert.ToInt16(Console.ReadLine());

            if (sayi == 30)
            {
                Console.Write("Sayı Doğru Girildi.");
            }
            else
            {
                Console.Write("Sayı Yanlış Girildi.");
            } 

            int s1, s2, ort;
            Console.Write("Sınav 1: ");
            s1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Sayı 2: ");
            s2 = Convert.ToInt32(Console.ReadLine());
            ort = (s1 + s2) / 2;
            Console.Write("Ortalamanız: " + ort);

            if (ort >= 50)
            {
                Console.Write(" | Geçtiniz.");
            }
            else
            {
                Console.Write(" | Kaldınız.");
            } 


            string kullanici, sifre;
            Console.Write("Kullanıcı Adınız: ");
            kullanici = Console.ReadLine();
            Console.Write("Şifreniz: ");
            sifre = Console.ReadLine();

            if (kullanici == "admin" && sifre == "1234")
            {
                Console.Write("Bilgiler Doğru");
            }
            else
            {
                Console.Write("Bilgiler Yanlış");
            } 

            int not1, not2, ort;
            Console.Write("Not 1: ");
            not1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Not 2: ");
            not2 = Convert.ToInt32(Console.ReadLine());
            ort = (not1 + not2) / 2;
            Console.WriteLine("Ortalamanız: " + ort);

            if (ort >= 80)
            {
                Console.WriteLine("Notunuz: AA");
            }
            if (ort >= 50)
            {
                Console.WriteLine("Notunuz: CC");
            }
            else
            {
                Console.WriteLine("Kaldınız.");
            } 



            Console.Read();





          
        }
    }
}

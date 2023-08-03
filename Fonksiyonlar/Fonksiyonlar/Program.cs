using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fonksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Math

             double sayi;
             Console.Write("Sayıyı Giriniz: ");
             sayi = Convert.ToDouble(Console.ReadLine());
             Console.WriteLine("Mutlak Değeri: " + Math.Abs(sayi));
             Console.WriteLine("Üst Taban: " + Math.Ceiling(sayi));
             Console.WriteLine("Alt Taban: " + Math.Floor(sayi));
             Console.WriteLine("Karekök: " + Math.Sqrt(sayi));  

            // String

            string metin, metin2;
            Console.Write("Metni giriniz: ");
            metin = Console.ReadLine();
            Console.Write("2. Metni giriniz: ");
            metin2 = Console.ReadLine();

            Console.WriteLine("Concat ile birleştirme: " + string.Concat(metin, metin2));
            Console.WriteLine("Metin 1 için karakter sayısı: " + metin.Length);
            Console.WriteLine("Indexof örneği: " + metin.IndexOf('a'));
            Console.WriteLine("Starwith örneği: " + metin.StartsWith("merhaba"));
            Console.WriteLine("     Merhaba Dünya    "+ metin.Trim());
            Console.WriteLine("Büyük Harf: " + metin.ToUpper());
            Console.WriteLine("Küçük Harf: " + metin.ToLower());
            Console.WriteLine("Remove metodu: " + metin.Remove(3));
            Console.WriteLine("Replace metodu: " + metin.Replace("a", "A"));
            Console.WriteLine("Substring metodu: " + metin.Substring(4)); 

            // Datetime

            
            Console.WriteLine("Bugünün gün bilgisi: " + DateTime.Now.Day);
            Console.WriteLine("Bugünün ay bilgisi: " + DateTime.Now.Month);
            Console.WriteLine("Bugünün yıl bilgisi: " + DateTime.Now.Year);
            Console.WriteLine("Bugünün saat bilgisi: " + DateTime.Now.Hour);
            Console.WriteLine("Bugünün dakika bilgisi: " + DateTime.Now.Minute);
            Console.WriteLine("Bugünün saniye bilgisi: " + DateTime.Now.Second);
            Console.WriteLine("Bugünün tarih bilgisi: " + DateTime.Now.ToShortDateString());
            Console.WriteLine("Bugünün uzun tarih bilgisi: " + DateTime.Now.ToLongDateString()); 

            // Time span
            
            
            TimeSpan zaman;
            int gunfarki;
            DateTime tarih1, tarih2;
            tarih1 =Convert.ToDateTime("08.08.2001");
            tarih2 =Convert.ToDateTime(DateTime.Now.ToShortTimeString());
            zaman = tarih2 - tarih1;
            gunfarki = zaman.Days;
            Console.Write("Fark: " + gunfarki); 

            


            
            
            




            Console.Read();
        }
    }
}

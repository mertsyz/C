﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {

            // STRING
             string sehir, Ilce;
             sehir = "İstanbul";
             Ilce = "Beylikdüzü";
             Console.Write(sehir+ " " + Ilce);
             Console.Read(); 

            // INT
            int sayi1, sayi2, toplam;
           
            sayi1 = 24;
            sayi2 = 59;
            toplam = (sayi1 + sayi2);
            Console.Write(toplam);
            Console.Read(); 

            int dikuzun, dikKısa, Alan, Cevre;

            dikuzun = 40;
            dikKısa = 20;
            Alan = (dikKısa * dikuzun);
            Cevre = (2 * dikuzun) + (2 * dikKısa);
            Console.WriteLine(Alan);
            Console.WriteLine(Cevre);
            Console.Read(); 

            int sayi1, sayi2, toplama, cikarma, carpma, bolme;
            Console.WriteLine("***** Aritmetik İşlemler *****");
            Console.WriteLine();
            sayi1 = 20;
            sayi2 = 5;
            toplama = sayi1 + sayi2;
            carpma = sayi1 * sayi2;
            cikarma = sayi1 - sayi2;
            bolme = sayi1 / sayi2;

            Console.WriteLine("Toplam = " + toplama);
            Console.WriteLine("Çarpım = " + carpma);
            Console.WriteLine("Fark = " + cikarma);
            Console.WriteLine("Bölüm = " + bolme);
            Console.WriteLine();
            Console.Read(); 


            string isim, soyisim, ders;
            int ort, vize, final;
          

            isim = "Mert";
            soyisim = "Söylemez";
            ders = "Matematik";

            vize = 85;
            final = 70;
            ort = (vize * 30 / 100) + (final * 40 / 100);

            Console.WriteLine("İsim: " + isim);
            Console.WriteLine("Soyisim: " + soyisim);
            Console.WriteLine("Ders: " + ders);
            Console.Write("Notu: " + ort);
            Console.Read(); 

            double sayi;
            sayi = 24.9;
            Console.Write(sayi);
            Console.Read(); 

            string sehir, ilce;
            Console.Write("Lütfen Şehrinizi Girin: ");
            sehir = Console.ReadLine();
            
            Console.Write("Lütfen İlçenizi Girin: ");
            ilce = Console.ReadLine();
            Console.WriteLine("Şehriniz: " + sehir + " " + "İlçeniz: " + ilce);
            Console.Read(); 


            int sayi;
            Console.Write("Sayı Giriniz: ");
            sayi = Convert.ToInt16(Console.ReadLine());

            Console.Write(sayi);
            Console.Read(); 

            int sayi1, sayi2, topla;
            Console.Write("1. sayıyı giriniz: ");
            sayi1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("2. sayıyı giriniz: ");
            sayi2 = Convert.ToInt16(Console.ReadLine());
            topla = sayi1 + sayi2;
            Console.WriteLine("Sayıların Toplamı: " + topla); 

            int dikUzun, dikKisa, alan, cevre;

            Console.Write("Diktörtgenin Uzun Kenarı: ");
            dikUzun = Convert.ToInt16(Console.ReadLine());
            Console.Write("Diktörtgenin Kısa Kenarı: ");
            dikKisa = Convert.ToInt16(Console.ReadLine());

            alan = (dikUzun * dikKisa);
            cevre = (2 * dikUzun) + (2 * dikKisa);

            Console.WriteLine("Diktörtgenin Alanı: " + alan);
            Console.WriteLine("Diktörtgenin Çevresi: " + cevre);

            Console.Read(); 

            double sayi1,sayi2, toplam;
            Console.Write("1. Ondalıklı Sayı: ");
            sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("2. Ondalıklı Sayı: ");
            sayi2 = Convert.ToDouble(Console.ReadLine());
            toplam = sayi1 + sayi2;
            Console.WriteLine(toplam);
            Console.Read(); 

            Console.Write("Lütfen Seçiminizi Yapınız: ");
            char secim = Convert.ToChar(Console.ReadLine());
            Console.Write("Seçiminiz: "+ secim);
           
            Console.Read(); 

            byte sayi = 27;
            byte sayi2 = 23;
            byte toplam = Convert.ToByte(sayi - sayi2);
            Console.WriteLine(toplam);
            Console.Read(); 

            Console.Write("float Sayı Girin: ");
            float sayi = float.Parse(Console.ReadLine());
            Console.Write("float Sayı Girin: ");
            float sayi2 = float.Parse(Console.ReadLine());
            float toplam = sayi + sayi2;
            Console.WriteLine("Sayıların Toplamı: " + toplam);
            Console.Read(); 

            Console.WriteLine(long.MaxValue);
            Console.WriteLine(double.MinValue);
            Console.Read(); 

            short sayi = 650;
            short sayi2 = 234;
            short toplam = (short)(sayi * sayi2);
            Console.WriteLine(toplam);
            Console.Read(); 

            Console.Write("Kenar giriniz: ");
            decimal kenar = Convert.ToDecimal(Console.ReadLine());
            decimal alan = kenar * kenar;
            decimal cevre = kenar * 4;
            Console.WriteLine("Alan: "+ alan + " Çevre: "+ cevre);
            Console.Read(); 

            bool durum = true;
            Console.Write("Öğrenci Sınavı Geçti mi?: ");
            Console.Write(durum);
            Console.Read(); 

        }
    }
}

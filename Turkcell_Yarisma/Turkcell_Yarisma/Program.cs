﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turkcell_Yarisma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Turkcell Bilgi Yarışmasına Hoşgeldiniz.");
            Console.WriteLine();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            int soru = 1;
            string cevap;
            if (soru == 1)
            {
                Console.WriteLine("Türkiyenin Başkenti Neresidir?");
                Console.WriteLine();
                Console.WriteLine("A) İstanbul");
                Console.WriteLine("B) İzmir");
                Console.WriteLine("C) Bursa");
                Console.WriteLine("D) Ankara");
                Console.WriteLine();
                Console.WriteLine("Cevabınız: ");
                cevap = Console.ReadLine();

                if (cevap == "d" || cevap == "D")
                {
                    soru += 1;

                }
                else
                {
                    Console.Write("Cevap Yanlış!");
                    Console.Write("Toplam Puan: 0");
                }

                
            }
            if(soru == 2)
            {
                Console.WriteLine("Cumhuriyet Kaç Yılında İlan Edilmiştir?");
                Console.WriteLine();
                Console.WriteLine("A) 1920");
                Console.WriteLine("B) 1923");
                Console.WriteLine("C) 1921");
                Console.WriteLine("D) 1919");
                Console.WriteLine();
                Console.WriteLine("Cevabınız: ");
                cevap = Console.ReadLine();

                if (cevap == "b" || cevap == "B")
                {
                    soru += 1;
                }
                else
                {
                    Console.WriteLine("Cevap Yanlış!");
                    Console.WriteLine("Toplam Puan: 1");
                }
            }
            if (soru == 3)
            {
                Console.WriteLine("Adana Hangi Coğrafi Bölgemizdedir?");
                Console.WriteLine();
                Console.WriteLine("A) Akdeniz");
                Console.WriteLine("B) Marmara");
                Console.WriteLine("C) Karadeniz");
                Console.WriteLine("D) İç Anadolu");
                Console.WriteLine();
                Console.WriteLine("Cevabınız: ");
                cevap = Console.ReadLine();

                if (cevap == "a" || cevap == "A")
                {
                    Console.WriteLine("Tebrikler Yarışmayı Kazandınız!");
                }
                else
                {
                    Console.WriteLine("Cevap Yanlış!");
                    Console.WriteLine("Toplam Puan: 2");
                }
            }
            







            Console.Read();
        }
    }
}

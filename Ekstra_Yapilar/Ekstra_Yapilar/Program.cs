using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekstra_Yapilar
{
    class Program
    {
        static void Main(string[] args)
        {
            // konsol arkaplan renk değiştirme 

             Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("asd"); 

            // Çok boyutlu diziler


             int[,] sayilar = new int[2,2];
            sayilar[0, 0] = 10;
            sayilar[0, 1] = 20;
            sayilar[1, 0] = 30;
            sayilar[1, 1] = 40;
            Console.Write(sayilar[0, 1]); 

            // yıldızlarla şekil oluşturma

             for( int i = 1; i < 11; i++)
            {
                Console.WriteLine("*****");
            } 

            for (int i= 1; i < 11; i++)
            {
                for(int j = 1; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            } 


            
           

            

            Console.Read();
        }
    }
}

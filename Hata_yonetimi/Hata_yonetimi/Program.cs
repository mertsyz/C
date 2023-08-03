using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hata_yonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            // hata yönetimi

            try
            {
                int s1, s2, sonuc;
                Console.Write("Sayı1: ");
                s1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Sayı2: ");
                s2 = Convert.ToInt32(Console.ReadLine());
                sonuc = s1 * s2;
                Console.Write("İşlem Sonucu: " + sonuc);
            }
            catch (Exception)
            {
                Console.WriteLine("Hata");
            }
            finally
            {
                Console.WriteLine("Burası Çalıştı");
            }
            catch(FormatException)
            {

                Console.WriteLine("Sadece sayısal değer giriniz.");
                
            }
            catch(OverflowException)
            {
                Console.WriteLine("Lütfen aralağın dışında değer girmeyin.");
            } 



            Console.Read();
        }
    }
}

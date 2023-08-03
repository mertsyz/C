using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sıniflar
{
    class Musteri
    {
        public int ID;
        private string adSoyad;
        private string sehir;

        public string AdSoyad { get => adSoyad; set => adSoyad = value.ToUpper(); }
        public string Sehir { get => sehir; set => sehir = value.ToUpper(); }
    }
}

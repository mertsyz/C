using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sıniflar
{
    class Kuslar
    {
        public string tur;
        public int hiz;
        public double agirlik;

        public virtual string sescikar()
        {
            return "buraya ses yazılacak";
        }
    }
}

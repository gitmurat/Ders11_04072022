using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40_Collections
{
    internal class Dikdortgen:Kare

    {
        public int Kenar2 { get; set; }
        public override int Alan
        {
            get { return Kenar * Kenar2; }
        }

        public override string ToString()
        {
            return Kenar + " x " + Kenar2 + " = " + Alan; 
        }
    }
}

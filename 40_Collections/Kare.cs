using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40_Collections
{
    internal class Kare
    {
        public int Kenar { get; set; }
        public virtual int Alan 
        {
            get { return Kenar * Kenar; } 
        }

        public override string ToString()
        {
            return Kenar + " x " + Kenar + " = " + Alan;
        }
    }
}

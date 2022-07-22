using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_OOP_Ders14_22072022
{
    internal class Daire
    {
        public double YariCap { get; set; }
        public const double PI = 3.14;

        public override string ToString()
        {
            return Convert.ToString(YariCap);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_OOP_Ders14_22072022
{
    internal class Kisi
    {
        public string Adi { get; set; }

        private readonly string _TC = "123412"; //readonly acces modifier only allows the constructor to set the initial value of the property. If an initial assignment has been done, that will be used as default but the parameter in the constructor will override this value
        public string TC
        {
            get
            { return _TC; }
        }

        public Kisi(string tc)
        {
            _TC = tc;
        }

        public override string ToString()
        {
            return TC + " " + Adi;
        }
    }
}

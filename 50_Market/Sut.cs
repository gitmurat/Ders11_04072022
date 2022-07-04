using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _50_Market
{
    internal class Sut : Urun
    {
        public override string Tip => "Süt";            //=> lamda operatörü get return mekanizmasının kısaltmasıdır.
        public override string Marka => "Pinar";

        public override string BaslikBelirle()
        {
            string sonuc = base.BaslikBelirle()+ " " + Hacim + " ";
            if (LightMi)
            {
                sonuc += "(Diyet)";
            }

            return sonuc;
        }
        
        public string Hacim { get; set; }
        public bool LightMi { get; set; }

    }
}

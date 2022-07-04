using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _50_Market
{
    internal class Pil: Urun
    {
        public override string Marka => "Duracell";
        public override string Tip => "Pil";
        public string  Tur { get; set; }

        public override string BaslikBelirle()
        {
            string sonuc = base.BaslikBelirle();
            sonuc += Tur + " ";
            return sonuc;
        }
    }
}

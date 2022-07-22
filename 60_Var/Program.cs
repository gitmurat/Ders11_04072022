using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _60_Var
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Sayi = 5;
            string Kelime = "Kelime";

            var Sayi2 = 10;
            var Kelime2 = "Kelime2";
            var Acikmi = true;
            //var is a generic type that accepts all value types but can only be used with an initial assignment. We cannot define a var type without an initial assignement because the initial assignment tells c# what kind of value is contained in var.

            Console.WriteLine(Kelime2.ToUpper());
            Console.WriteLine(Sayi2*10);
        }
    }
}

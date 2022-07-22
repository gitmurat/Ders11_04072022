using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi = 5;
            long sayi2 = sayi; //implicit

            long sayi3 = 5;
            int sayi4 = (int)sayi3; //explicit type conversion.

            long sayi5 = Convert.ToInt64(sayi);
            int sayi6 = Convert.ToInt32(sayi2);

            string txt = "123";
            string str = "";

            int sayi7 = int.Parse(txt);
            int sayi8 = Convert.ToInt32(txt);
            int sayi9 = Convert.ToInt32(str); //convert will always convert the text to number. If the string is not in a number format it will return the standard int value of 0 (zero)

            Convert.ToBoolean(123); //except for 0 all numbers will be converted to true only zero will be converted to false
        }
    }
}

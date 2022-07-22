using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Dikdortgen> dortgenler =  new List<Dikdortgen>();
            List<Kare> kareler = new List<Kare>();

            Dikdortgen dikdortgen1 = new Dikdortgen { Kenar = 10, Kenar2 = 20 };
            dortgenler.Add(dikdortgen1);
            dortgenler.Add(new Dikdortgen { Kenar = 5, Kenar2 = 7 });

            kareler.Add(new Kare { Kenar = 5 });
            kareler.Add(new Kare { Kenar = 13 });

            foreach (Dikdortgen item in dortgenler)
            {
                Console.WriteLine("Dikdörtgen = " + item);
            }

            foreach (Kare item in kareler)
            {
                Console.WriteLine("Kare = "+ item);
            }

            kareler.AddRange(dortgenler);

            foreach(Kare item in kareler)
            {
                Console.WriteLine(item);
            }
        }
        static void Main1(string[] args)
        {
            //Kare[] kareler = new Kare[10];
            //int[] sayilar = new int[3];

            //both of the above statements limit the number of values that can be added to the array due to the nature of array definition. Instead we can use more generic lists. In ArrayList we can list any type of object but generic lists gives us the advantage of statign the data type and we only add that data type to the list. This means in Lists we do not have to do boxing/unboxing as we have to in ArrayList.

            List<string> kelimeler = new List<string>(); //<types> is called a generalization
            kelimeler.Add("aa");
            kelimeler.Add("bb");

            List<int> sayilar = new List<int>();
            sayilar.Add(1);
            sayilar.Add(123);

            foreach (string item in kelimeler)
            {
                Console.WriteLine(item.ToUpper());
            }

            Console.WriteLine("-----------------------------");

            foreach (int item in sayilar)
            {
                Console.WriteLine(item);
            }

        }
    }
}

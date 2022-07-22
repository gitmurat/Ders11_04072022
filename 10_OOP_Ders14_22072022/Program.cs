using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_OOP_Ders14_22072022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kisi kisi1 = new Kisi("12344321") { Adi = "Murat" };
            Kisi kisi2 = new Kisi("56258625") { Adi = "Larisa" };
            Kisi kisi3 = new Kisi("41451324") { Adi = "Mert" };

            Daire daire = new Daire();
            daire.YariCap = 10.5;

            Console.WriteLine("Alan = " + daire.YariCap * Daire.PI);

            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add(true);
            list.Add("Balcı");
            list.Add(daire); //when ToString method coming from the base class "object" is not overriden the instance will be coverted to text as "namespace + class name"
            list.Add(10.5m);
            list.Add(kisi1);
            list.Add(kisi1);
            list.Add(kisi2);
            list.Add(kisi3);
            list.Remove(1);
            list.Remove(true);
            list.RemoveAt(3); //removes the object stated in the index value provided. The above lines removed the 0th and 1st indeces so the 3rd index is now kisi1

            foreach (object item in list)
            {
                if (item is Kisi)
                {
                    Kisi k = (Kisi)item;
                    Console.WriteLine(k.Adi.ToUpper());
                }
                
            }
        }
    }
}

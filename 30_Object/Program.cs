using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_Object
{
    class Kisi //all classes, even if they are not derived from another class are derived from a base class called "object" which has properties/methods such as ToString() etc.
    {
        public string Adi { get; set; }
        public override string ToString()
        {
            return Adi;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kisi kisi = new Kisi() { Adi = "İlker" };
            //Console.WriteLine(kisi); 

            //when we use CW any value that we want to have written on the console are converted to string by the ToString Method in the object. So when we only have "kisi" as a parameter since we overrode the ToString method it will output whatever we have set the return to.

            object sayi = 5; //object can be used to define any type of value but has very limited usability
            object isim = "Berat";

            Kisi kisi = new Kisi() { Adi = "İlker" };
            object ob = kisi;
            int Sayi = 5;
            object sa = Sayi; //this type conversion from specific types to object is called boxing

            int sayi2 = (int)sa; // this type conversion from object to specific types is called unboxing
            Kisi kisi2 = (Kisi)ob;

            Console.WriteLine(kisi2.Adi);
        }
    }
}

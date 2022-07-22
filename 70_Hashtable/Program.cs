using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _70_Hashtable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht= new Hashtable(); //hashtable is a list with two values; one key and one value and accepts any object
            ht.Add("06", "Ankara");
            ht.Add("34", "İstanbul");
            ht.Add("10", "Balıkesir");
            ht["61"] = "Trabzon";
            //ht.Remove("61");

            //Console.WriteLine(ht["06"]);

            foreach (var item in ht.Values)
            {
                Console.WriteLine(item);
            }

            foreach(var key in ht.Keys)
            {
                Console.Write(key);
                Console.WriteLine(" " + ht[key]);
            }
            Hashtable ht2 = new Hashtable();
            ht2.Add(3, "üç");
            ht2.Add(5, "beş");

            foreach (var item in ht2.Values)
            {
                Console.WriteLine(item);
            }
        }
    }
}

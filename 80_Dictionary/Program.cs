using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _80_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dic = new Dictionary<int, string>(); //Dictionary is exactly the same as hashtable but uses generic types so that it is more consistent

            dic.Add(6, "Ankara");
            dic.Add(34, "İstanbul");
            dic.Add(60, "Tokat");
            dic.Add(10, "Balıkesir");

            foreach (var key in dic.Keys)
            {
                Console.WriteLine(key + " - " + dic[key]); 
            }
        }
    }
}

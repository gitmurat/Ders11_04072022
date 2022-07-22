using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _50_Collections
{
    internal class Program
    {
        static void Show(List<int> values)
        {
            int rowcount=0;
            foreach (int item in values)
            {
                Console.WriteLine(rowcount++ + " - "+ item);
            }
            Console.WriteLine("---------------------");
            Console.WriteLine(values.Count+ " items");
        }
        
        static void Main(string[] args)
        {
            List<int> list1 = new List<int> { 4, 5, 6, 7 };
            List<int> list2 = new List<int> { 11, 15, 16, 1 };

            list2.AddRange(list1); //AddRange adds one list to another
            list2.Sort();
            list2.Remove(5);
            //list2.Remove(list2[0]); this and the below are the same
            list2.RemoveAt(5);
            Show(list2);

            Console.WriteLine(list2[3]);
        }
    }
}

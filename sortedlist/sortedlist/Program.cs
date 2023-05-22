using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortedlist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList<int,string> list = new SortedList<int,string>();
            list.Add(1, "satara");
            list.Add(2, "pune");
            list.Add(3, "mumbai");
            list.Add(4, "Kolhapur");

            foreach(var i in list)
            {
               Console.WriteLine("key :{0} , value: {1} " , i.Key, i.Value);
                 // Console.WriteLine("key: {0} , value: {1}"  , kvp.Key , kvp.Value);
            }

            Console.WriteLine("Remove kolhapur from list");

            list.Remove(4);
            foreach (var i in list)
            {
                Console.WriteLine("key :{0} , value: {1} ", i.Key, i.Value);
                // Console.WriteLine("key: {0} , value: {1}"  , kvp.Key , kvp.Value);
            }

        }
    }
}

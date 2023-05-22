using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace list1
{
    internal class Program
    {
        static void Main(string[] args)
        {
          

            List<int> demo = new List<int>();
            demo.Add(1);
            demo.Add(2);
            demo.Add(3);
            demo.Add(4);
            demo.Add(5);
            for (int i = 0;i<5; i++)
            {
                Console.WriteLine("simple intege list:" + demo[i]);

            }
            Console.WriteLine("\nsize of list:" + demo.Count);

            string[] cities = new string[3] { "Mumbai", "London", "New York" };

            var popularCities = new List<string>();

            // adding an array in a List
            popularCities.AddRange(cities);

            for (int i  = 0; i < cities.Length; i++) 
            {
                Console.WriteLine("\nadding city array list in liststring: " + i);
            }

            Console.WriteLine("\nadding element in list");

            demo.Insert(1, 10);

            foreach(var i in demo)
            {
                Console.WriteLine(i);
            }

            demo.Remove(10);
            demo.RemoveAt(demo.Count - 1);

            Console.WriteLine("after applying remove");

            foreach (var i in demo)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("check where element i in list or not:");
            int m = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine( demo.Contains(m));
        }
    }
}

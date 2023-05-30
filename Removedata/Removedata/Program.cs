using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Removedata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("Enter Test Data");
            name = Console.ReadLine();

            char[] ch = name.ToCharArray();

            Console.WriteLine(ch);

            
            Console.WriteLine(name.Remove(2, 1));




        }
    }
}

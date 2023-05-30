using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringpalino
{



    internal class Program
    {


        
       public  static void Main(string[] args)
        {
            string name;
            Console.WriteLine("Enter your string");
            name = Console.ReadLine();

            char[] chars = name.ToCharArray();
            Array.Reverse(chars);
            Console.WriteLine(string.Join("", chars));

            Console.WriteLine("reverse string uaing for loop");

            for(int i = name.Length - 1; i > 0; i--)
            {
                Console.WriteLine(name[i]);
            }


        }
    }
}

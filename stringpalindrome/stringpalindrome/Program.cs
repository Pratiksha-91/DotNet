using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringpalindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;

            Console.WriteLine("enter your string");
            name = Console.ReadLine();

            for (int i = 0; i< name.Length; i++)
            {

                Console.WriteLine(name[i]);
            }

        }

        
    }
}

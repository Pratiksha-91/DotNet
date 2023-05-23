using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n;

            Console.WriteLine("enter number");

            n = Convert.ToInt32(Console.ReadLine());

            for(int i =  0; i < n; i++)
            {
                for(int k  = 1; k <= i; k++)
                {
                    Console.Write(" ");
                }
                for(int j  = 0; j < n; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
    }
}

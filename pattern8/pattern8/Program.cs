using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace pattern8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n;
            Console.WriteLine("enter number of rows");
                n = Convert.ToInt32(Console.ReadLine());
                    
                for(int i = 0; i < n; i++)
            {
                int star = i + 1;

                for(int j = 0;j<star;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

                for(int i = 1;i<n;i++)
            {
                int star = n - i;

                for(int j = 0 ; j < star; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
    }
}

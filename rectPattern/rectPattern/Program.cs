using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace rectPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("enter number of rows");
            n = Convert.ToInt32(Console.ReadLine());

            for(int i = 0;i < n;i++)
            {     
               for(int k  = 0;k < n - i ;k++)
                {
                    Console.Write(" ");
                }

                for(int j  = 1;j <= i + 1;j++)
                {
                    Console.Write(" ");
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for(int i = n - 1 ; i > 0;i--)
            {
                for(int k  = 0; k <= n-i;k++)
                {
                    Console.Write(" ");
                }

      
                for(int j = 1;j <= i;j++)
                {
                    Console.Write(" ");
                    Console.Write( "*");
                }
                
                Console.WriteLine();
            }
        }
    }
}

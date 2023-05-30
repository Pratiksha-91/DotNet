using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern112
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter num ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < i; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j < n - i; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }

                for (int i = 0; i < n; i++)
                {
                    for (int k= 0; k < n - i; k++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 1; j < i + 1; j++)
                    {
                        
                        Console.Write(" *");
                    }
                    Console.WriteLine();
                }
            
        }
    }
}

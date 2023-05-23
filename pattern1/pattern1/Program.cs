using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("enter number");
            n = Convert.ToInt32(Console.ReadLine());
            
            for(int i =0; i< n; i++)
            {
                int space = n - i - 1;

                for (int j =1; j< space;i++)
                {
                                  
                    
                        Console.Write(" p");
                  }
                    for(int k =0; k< i + 1; k++)
                    {
                        Console.Write("*");
                    }
                Console.WriteLine("*");
            }


        }
    }
}

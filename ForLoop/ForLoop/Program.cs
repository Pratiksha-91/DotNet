using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int[] a_array = { 1, 2, 3, 4, 5, 6, 7, 8, };
            Console.WriteLine("Array Element are:");
            for (int i=0;i<a_array.Length;i++)
            {
               
                Console.WriteLine(a_array[i]);
            
           
            }

        }
    }
}

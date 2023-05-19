using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatedisplayArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a_array = new int[3];

            Console.WriteLine("enter arrat elemnt");
            for(int i=0; i<a_array.Length; i++)
            {
                a_array[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(a_array[i]);
                Console.WriteLine();
            }
        }
    }
}

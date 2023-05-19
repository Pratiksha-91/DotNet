using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oneDArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];

            Console.WriteLine("enter array elemnt");
            for(int i=0;i<arr.Length;i++)
            {
            
               
                arr[i] = Convert.ToInt32(Console.ReadLine());
             }
            Console.Write("Array elements are: ");
            for (int i = 0; i < arr.Length; i++)
            {

                Console.Write(arr[i] + " ");
            }

            ;
        }

    }

}

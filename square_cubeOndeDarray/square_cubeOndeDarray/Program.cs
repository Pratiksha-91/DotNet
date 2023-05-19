using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace square_cubeOndeDarray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            int n;
            Console.WriteLine("enter size of array");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter array elements");
            for(int i=0;i<n;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Accepted array is:");
            for(int i = 0;i<n;i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine("Square of array elements:");

            for(int i =0;i<n;i++)
            {
                int square = arr[i] * arr[i];
                Console.WriteLine(square + " ");
            }
            Console.WriteLine("cube of elements:");
            for(int i=0;i<n;i++)
            {
                Console.WriteLine(arr[i] * arr[i] * arr[i] + " ");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverse_additionOneD_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];

            Console.WriteLine("Enter array element");
            for(int i=0; i<arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Accepted array is=");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
            
            int[] temp = arr;
            Array.Reverse(temp);
            Console.WriteLine("Reverse array is:");
            foreach(int i in temp)
                    {
                Console.Write(i + " ");
            }

            Console.WriteLine("Addition of array elements:");
            int sum = 0;
            for(int i = 0; i < arr.Length;i++)
            {
                sum = sum + arr[i];

            }
            Console.WriteLine("Additon of array is:" + sum);
        }

    }
}

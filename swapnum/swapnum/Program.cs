using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swapnum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 7;

            Console.WriteLine("numbers before swapping");
            Console.WriteLine("num1 = " + num1);
            Console.WriteLine("num2 = " + num2);

            num1 = num2 ;

            num2 = num1 - 2;
            Console.WriteLine("numbers after swapping");
            Console.WriteLine("num1 = " + num1);
            Console.WriteLine("num2 = " + num2);

        }
    }
}

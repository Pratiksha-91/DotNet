using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, rem, sum = 0;

            num = Convert.ToInt32(Console.ReadLine());
            int original = num;

            while (num > 0)
            {
                rem = num % 10;
                sum = sum * 10 + rem;
                num = num / 10;

            }
            // Console.WriteLine(sum);
            if( sum == original ) {

                Console.WriteLine("IS PALINDROME");
            }
            else
            {
                Console.WriteLine("NOT PALINDROME");
            }
                 }
    }
}

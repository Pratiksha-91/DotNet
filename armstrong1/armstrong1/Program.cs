using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace armstrong1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, rem=0, temp=0,sum=0;

            Console.WriteLine("enter number");
            num =Convert.ToInt32( Console.ReadLine());
            temp=num;

            while(num > 0)
            {
                rem = num % 10;
                sum = sum + (rem * rem * rem);
               num = num / 10;
             
            }


          
           
            if (temp == sum)
            {
                Console.WriteLine("armstrong");
            }
            else
            {
                Console.WriteLine("not armstrong");
            }
        }
    }
}

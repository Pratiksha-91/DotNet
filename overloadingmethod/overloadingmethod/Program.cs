using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overloadingmethod
{
    class demo
    {
        public int add(int a,int b)
        {
            int sum = a + b;
            return sum;
        }

        public int add(int a, int c, int b)
        {
            int sum2 = a + b + c;
            return sum2;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            demo obj = new demo();
            int sum11 = obj.add(1,2);
            Console.WriteLine("Addition of two integers is:" + sum11);

            int sum22 = obj.add(2,2,2);
            Console.WriteLine("Addition of three integers:" + sum22);

        }
    }
}

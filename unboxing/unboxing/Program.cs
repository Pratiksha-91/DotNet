using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num;
            Console.WriteLine("enter integer value");

            num = Convert.ToInt32(Console.ReadLine());

            object y = num; //boxing

            Console.WriteLine(y + "  this is example of boxing");

            int z = (int)y; //unboxing
            Console.WriteLine(z);

        }
    }
}

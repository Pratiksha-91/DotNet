using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch1
{
    internal class Program
    {

        public void add()
        {
            int num1, num2;

            Console.WriteLine("Enter value of num1 and num2");

            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());

            int num3 = num1 + num2;

            Console.WriteLine("Addition of two number is:" + num3);
        }

        public void multiple()
        {
            int num1, num2;

            Console.WriteLine("Enter value of num1 and num2");

            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());

            int num3 = num1 * num2;

            Console.WriteLine("multiple of two number is:" + num3);

        }


        static void Main(string[] args)
        {
            Program obj = new Program();

            int x;
            Console.WriteLine("Enter case number:");
            x = Convert.ToInt32(Console.ReadLine());

            

            switch(x)
            {
                case 1:
                    obj.add();
                    break;

                case 2:
                    obj.multiple();
                    break;
                 default:

                    Console.WriteLine("hey");
                    break;

            }
        }
    }
}

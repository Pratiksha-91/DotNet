using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {

        public void add()
        {
            int num1, num2;
            Console.WriteLine("Enter num1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num1");
            num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = num1 + num2;
            Console.WriteLine("Addition is=" + num3);
        }

        public void substraction()
        {
            int num1, num2;
            Console.WriteLine("Enter num1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num1");
            num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = num1 - num2;
            Console.WriteLine("substraction is=" + num3);
        }

        public void mult()
        {
            int num1, num2;
            Console.WriteLine("Enter num1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num1");
            num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = num1 * num2;
            Console.WriteLine("multiplication is=" + num3);
        }

        public void divide()
        {
            int num1, num2;
            Console.WriteLine("Enter num1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num1");
            num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = num1 % num2;
            Console.WriteLine("division is=" + num3);
        }
        static void Main(string[] args)
        {

            Program obj = new Program();
            
                Console.WriteLine("Press 1 for Addition");
                Console.WriteLine("Press 2 for Substraction");
                Console.WriteLine("Press 3 for multiplication");
                Console.WriteLine("Press 4 for Division");

                int x;
                Console.WriteLine("enter case number");
                x = Convert.ToInt32(Console.ReadLine());

            
            
                switch (x)
                {
                    case 1:
                        obj.add();
                        break;

                    case 2:
                        obj.substraction();
                        break;

                    case 3:
                        obj.mult();
                        break;

                    case 4:
                        obj.divide();
                        break;

                
            }
        }
    }
}

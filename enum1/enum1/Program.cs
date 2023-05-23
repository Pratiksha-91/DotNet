using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enum1
{
    internal class Program
    {
        enum Level
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday

        }
                   static void Main(string[] args)


        {
            int x;
            Console.WriteLine("Enter number");
            x = Convert.ToInt32(Console.ReadLine());

            Level obj;

            switch(x)
            {
                case 1:
                    obj = Level.Monday;
                    Console.WriteLine("Todays is:" + obj);
                    break;

                case 2:
                    obj = Level.Tuesday;
                    Console.WriteLine("Todays is:" + obj);
                    break;

                case 3:
                    obj = Level.Wednesday;
                    Console.WriteLine("Todays is:" + obj);
                    break;

                case 4:
                    obj = Level.Thursday;
                    Console.WriteLine("Todays is:" + obj);
                    break;
            }
        }
    }
}


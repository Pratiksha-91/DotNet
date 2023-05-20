using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace validD
{


    public class Demo
    {
        public int dd, mm, yy;

        public void accept()
        {
            Console.WriteLine("Enter date");
            dd = Convert.ToInt32(Console.ReadLine());


            if (dd < 1) 
            {
                Console.WriteLine("Date is not valid");
            }

            else if (dd > 31)
                {
                    Console.WriteLine("Date is not valid");
                }

            Console.WriteLine("Enter Month");
            mm = Convert.ToInt32(Console.ReadLine());

            if (mm < 1)
            {
                Console.WriteLine("Date is not valid");
            }

            else if (mm > 13)
            {
                Console.WriteLine("Date is not valid");
            }

            Console.WriteLine("Enter year");
            yy = Convert.ToInt32(Console.ReadLine());

            if (yy < 1000)
            {
                Console.WriteLine("Date is not valid");
            }

            else if ( yy > 3000)
            {
                Console.WriteLine("Date is not valid");
            }

            Console.WriteLine("Entered date is :" + dd + "/" + mm + "/" + yy);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Demo obj = new Demo();
            obj.accept();
        }
    }
}

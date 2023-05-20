using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static1
{
    public static class demo
    {
        public static int radius = 2;
            public static double area(int r)

        {
            
            return (3.14 * r *r) ;
        }
    }
    internal class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Area of circle is= " + demo.area(2));
            Console.WriteLine("Radius is = " + demo.radius);
            

        }
    }
}

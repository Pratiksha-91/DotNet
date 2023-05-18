using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_overriding
{
    class demo
    {
        public virtual void show()
        {
            Console.WriteLine("base class");
        }
    }

    class demo2 : demo
    {
        public override void show()
        {
            Console.WriteLine("Derived class");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            demo obj;
            obj = new demo();
            obj.show();

            obj = new demo2();
            obj.show();
        }
    }
}

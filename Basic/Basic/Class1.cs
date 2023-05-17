using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    internal class Class1
    {
        string name;
        public void display()
        {
            Console.WriteLine("Enter your name ");
            name = Console.ReadLinr();
            Console.WriteLine("Name is {0} ", name);
        }
    }
}

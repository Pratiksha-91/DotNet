using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace property
{
    internal class Program
    {
        class demo
        {
            private string name;

            public string Name
            {
                
                get { return name; }
                set { name = value; }
            }
        }
        static void Main(string[] args)
        {
           demo obj = new demo();
            obj.Name = "Pratiksha";
            Console.WriteLine(obj.Name);

        }
    }
}

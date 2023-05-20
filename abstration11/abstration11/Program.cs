using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace abstration11
{
     abstract class  staff
    {
        protected int id;
        protected string name;

       public staff(int id, string name)
        {
            this.id = id;
            this.name = name;
            Console.WriteLine(this.id + " name of person id belong to is = " + name);
        }
    }

    class office : staff
    {

    }

    internal class Program
    {
        static void Main(string[] args)
        {

           
        }
    }
}

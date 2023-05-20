using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraction
{

    public abstract class Animal
    {
        public abstract void name();
        public abstract  void Type();
    }

     class lion : Animal
    {
            public override void name() 
        {
             Console.WriteLine("name is= lion");
        }

        public override void Type() 
        {
            Console.WriteLine("it is wild animal");
            }
    }

    class crocodile : Animal
    {
        public override void name()
        {
            Console.WriteLine("It is Crocodile");
        }

        public override void Type()
        {
            Console.WriteLine("Live in water");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            crocodile obj = new crocodile();
            obj.name();
            obj. Type();


            lion obj1 = new lion();
            obj1.name();
            obj1.Type();
        }
    }
}

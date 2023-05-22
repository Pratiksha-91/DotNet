using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> demo = new Stack<int>();

            demo.Push(1);
            demo.Push(2);   
            demo.Push(3);
            demo.Push(4);
            demo.Push(5);
            
            
            foreach(int i in demo)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("remove from stack");
            if(demo.Count > 0 )
            {
                Console.WriteLine(demo.Pop());
            }
            Console.WriteLine("Peek");
            if (demo.Count > 0)
            {
                Console.WriteLine(demo.Peek());
            }
        }
    }
}

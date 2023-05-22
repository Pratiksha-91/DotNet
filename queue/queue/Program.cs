using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queue
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Queue<int> demo = new Queue<int>();
            demo.Enqueue(1);
            demo.Enqueue(2);
            demo.Enqueue(3);

            foreach(var item in demo)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("size of queue: " + demo.Count);

            Console.WriteLine("delete element from queue");
            Console.WriteLine(demo.Dequeue());


            Console.WriteLine("after delete ");
            foreach (var item in demo)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("using peek function");
            Console.WriteLine(demo.Peek());

            Console.WriteLine("using peek");
            foreach (var item in demo)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("enter value that u want to check");

            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");

        }
    }
}

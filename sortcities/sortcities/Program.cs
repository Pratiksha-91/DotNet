
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraylist1

{


    internal class Program
    {
        static void Main(string[] args)
        {

            var mainlist = new ArrayList();
           var list = new ArrayList();
            list.Add(1);
            list.Add(2);
            list.Add("pratiksha");
            list.Add("3.4");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            int[] arr = new int[5] { 1,2,3,4,5};

            Queue myQ = new Queue();
            myQ.Enqueue("hello");
            myQ.Enqueue("world");

            
            mainlist.AddRange(arr);
            mainlist.AddRange(list);
            mainlist.AddRange(myQ);

            Console.WriteLine("Hetrogeneous arraylist is:");

            foreach (var item in mainlist)
            {
                Console.WriteLine(item);
            }

            var obj = new ArrayList();
            obj.Add("satara");

            mainlist.InsertRange(1,obj);
            Console.WriteLine("after adding satara");
            foreach (var item in mainlist)
            {
                
                Console.WriteLine(item);
            }

            mainlist.Remove("satara");

            Console.WriteLine("after removing satara");
            foreach (var item in mainlist)
            {

                Console.WriteLine(item);
            }



            Console.WriteLine(mainlist[0]);


            ArrayList demo1 = new ArrayList();
            demo1.Add(1);
            demo1.Add(2);
            demo1.Add(3);

            foreach (var item in demo1)
            {
                Console.WriteLine(item);
            }
        }
    }
}

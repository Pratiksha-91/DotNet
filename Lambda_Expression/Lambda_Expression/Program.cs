using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            /*int n;
            Console.WriteLine("enter size of list");
            n = Convert.ToInt32(Console.ReadLine());*/
            int n = 5;
            

            Console.WriteLine("enter List element:");

           


            for (var i = 0; i < n; i++)
            {
                int input = Convert.ToInt32(Console.ReadLine());
                numbers.Add(input);
            }

            for (var i = 0; i <numbers.Count; i++)
            {
                Console.WriteLine("List is = " + numbers[i]);
            }


            
            
                
                var square = numbers.Select(a => a * a);
                Console.WriteLine(String.Join(",",square)   );
            
        }
    }
}

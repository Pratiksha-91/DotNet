using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambdaWithDictonary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            Dictionary<int,int> dict1 = new Dictionary<int, int>();
            Console.WriteLine("key and value in disctionary");

            for(int i = 0; i < n; i++) 
            {

                var key1 = Convert.ToInt32(Console.ReadLine()); 

               var valu1 = Convert.ToInt32(Console.ReadLine());

                dict1.Add(key1,valu1);

             }

           foreach(var i in dict1) {

        
                Console.WriteLine( i.Key  + ":"  + i.Value);
            
            }



                var square = dict1.Values.Select(x => x * x);
                Console.WriteLine(String.Join(", ", square));
            


        }
    }
}

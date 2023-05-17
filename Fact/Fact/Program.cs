using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fact
{
    internal class Program
    {
        public void Calc(int n)
        {
            int f = 1;
            
            for(int i=1;i<=n;i++)
            
            {

                f = f * i;
               
            }
                Console.WriteLine("Factorial value is " +f);
         }
        
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter N Value ");
            n = Convert.ToInt32(Console.ReadLine());
            Program obj = new Program();
            obj.Calc(n);
              
        }
    }
}

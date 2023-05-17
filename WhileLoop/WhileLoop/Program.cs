using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop
{
    internal class Program
    {
        public void Show(int n)
        {
            int i = 0;
            while(i <= n)
            {
                Console.WriteLine("Welcome to Dotnet....");
                i++;
            }
        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter N value ");
            n = Convert.ToInt32(Console.ReadLine());
            Program obj = new Program();    
            obj.Show(n);
        }
    }
}

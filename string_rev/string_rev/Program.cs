using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_rev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            name = Console.ReadLine();
            string temp = name;
            string rev = "";


            Console.WriteLine(name.Length);
            for (int i = name.Length - 1; i>=0;i--)
            {
                

                Console.WriteLine(name[i]);
                rev = rev + name[i];
             }
        
            Console.WriteLine(rev);
           if( temp == rev)

            {
                Console.WriteLine("is palindrome");
            }
                     else
            {
                Console.WriteLine("not");
            }
            

        }
    }

}
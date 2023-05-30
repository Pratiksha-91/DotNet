using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swapletter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;

            Console.WriteLine("enter string");
            name = Console.ReadLine();

            char[] ch = name.ToCharArray();

            if (name.Length > 2)
            {

                char temp = ch[0];
                ch[0] = ch[ch.Length - 1];
                ch[ch.Length - 1] = temp;

                Console.WriteLine(ch);
            }

            else
            {
                Console.WriteLine("enter string more than two characters");
            }
            

        }
    }
}

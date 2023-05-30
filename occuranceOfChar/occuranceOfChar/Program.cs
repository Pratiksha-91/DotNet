using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace occuranceOfChar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string ch;
            int count1 = 0;

            Console.WriteLine("enter string");

            ch = Console.ReadLine();

            for (int i = 0; i < ch.Length; i++)
            {
                Console.WriteLine(ch[i]);

                for (int j = 0; j < ch.Length; j++)
                {
                    if (ch[j].Equals(ch[i]))
                    {
                        count1++;
                    }
                    Console.WriteLine(ch[j] + " : " + count1);
                }

            }

        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n;
            Console.WriteLine("enter number");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
               

                for (int j = 0; j < n - i ; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < i  + 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }



        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarPattern1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for(int i =0; i<5;i++)
            {
                for(int j =0;j <5;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}

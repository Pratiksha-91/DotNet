﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenShow
{
    internal class Program
    {
        public void Show(int n)
        {
            int i = 0;
            while(i<=n)
            {
                i = i + 2;
                Console.WriteLine("Even: " + i);
            }
        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter N value");
            n = Convert.ToInt32(Console.ReadLine());
            Program obj = new Program();
            obj.Show(n);
            
        }
    }
}

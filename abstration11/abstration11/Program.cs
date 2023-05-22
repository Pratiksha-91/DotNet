using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace abstration11
{
    public class demo
    {
        
        public static void accept()
        {
            int a = 100;
        }

        public void ab()
        {
            a = 20;
        }

        public void ase()
            {
            a = 30;
            Console.WriteLine(a);
            }

    }

      

    internal class Program
    {
        static void Main(string[] args)
        {
            static int a = 10;
            demo d = new demo();
            

            demo.accept();
            d.ab();
            d.ase();

            Console.WriteLine(a);

        }
    }
}

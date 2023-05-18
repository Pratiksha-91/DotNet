using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace impletinherit
{
    class demo
    {
        public string name, LastName;
        public int age;

        public void display()
        {
            Console.WriteLine("Enter your details");

            name = Console.ReadLine();

            LastName = Console.ReadLine();

            Console.WriteLine("Employee's name is=" + name + LastName);
            Console.WriteLine("enter your age");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Age of employee=" + age);
        }

    }

    class demo2 : demo
    {
        public string city;

        public void accept2()
        {
            Console.WriteLine("Enter your city you belong=");
            city = Console.ReadLine();
            Console.WriteLine(city);
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            demo2 obj = new demo2();
            obj.display();
            obj.accept2();  

        }
    }
}
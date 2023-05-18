using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    public class emp
    {
       public int id;
        public string name;
        public float salary;

       public emp(int id, string name, float salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }

        public void display()
        {
            Console.WriteLine("Id=" + id + "    name=" + name + "    salary=" + salary);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            emp obj = new emp(1,"ram",200);
            obj.display();
        }
    }
}

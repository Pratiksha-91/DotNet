using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anstrattion
{

    public abstract class staff
    {
        public abstract void empData();
    }

    public  class staff2 : staff {

        public String dpt;
    
        
        public override void empData()
        {

            int id;
            string name;

            Console.WriteLine("enter your id,name and department ");
            id = Convert.ToInt32(Console.ReadLine());
            name = Console.ReadLine();

            dpt = Console.ReadLine();

            Console.WriteLine("department name is" + dpt + " " + id + " " + name);

        }
       
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            staff2 obj = new staff2();
            obj.empData();
        }
    }
}

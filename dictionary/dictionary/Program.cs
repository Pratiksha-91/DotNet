using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string,string> demo = new Dictionary<string, string>();

            demo.Add("Country" ," India");
            demo.Add("state " ," Maharashtra");
            demo.Add("district "," Satara");

            foreach(var i in demo)
            {
                Console.WriteLine("keys : {0} , value : {1} " , i.Key , i.Value);
            }
        }
    }
}

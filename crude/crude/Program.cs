using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection sqlconnection;

            string sqlconnectionstring = @"Data Source=DESKTOP-5DQ2HPD\SQLEXPRESS;Initial Catalog=StudentCRUD;Integrated Security=True";

            sqlconnection = new SqlConnection(sqlconnectionstring);
            sqlconnection.Open();
            Console.WriteLine("Connection created");

           /* Console.WriteLine("Id :");
            int id = Convert.ToInt32(Console.ReadLine());*/

            Console.WriteLine("Name : ");
            string name = Console.ReadLine();

            Console.WriteLine("City : ");
            string city = Console.ReadLine();

            string insertQuery = "insert into student(name,city) values ( '"+name+"' , '"+city+"')";
            SqlCommand insertCommand = new SqlCommand(insertQuery, sqlconnection);
            insertCommand.ExecuteNonQuery();
            Console.WriteLine("Data Inserted");
            sqlconnection.Close();

            Console.ReadKey();

        }
    }
}

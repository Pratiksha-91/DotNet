using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud_select
{
    internal class Program
    {
        static void Main(string[] args)
        {


            SqlConnection sqlconnection;

            string sqlconnectionstring = @"Data Source=DESKTOP-5DQ2HPD\SQLEXPRESS;Initial Catalog=StudentCRUD;Integrated Security=True";

            sqlconnection = new SqlConnection(sqlconnectionstring);
            sqlconnection.Open();
          //  Console.WriteLine("Connection created");

           

            string selectQuery = "select * from student";
            SqlCommand display = new SqlCommand(selectQuery, sqlconnection);
            SqlDataReader dataReader = display.ExecuteReader();

            
            Console.WriteLine("data from table is");

            while (dataReader.Read())
            {
                
                Console.WriteLine("name = " +  dataReader.GetValue(1).ToString());
                Console.WriteLine("city = " + dataReader.GetValue(2).ToString());

            }
            dataReader.Close();
           
            sqlconnection.Close();

            Console.ReadKey();



        }
    }
}

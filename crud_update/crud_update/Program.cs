using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud_update
{
    
        internal class Program
        {
            static void Main(string[] args)
            {
                SqlConnection sqlconnection;

                string sqlconnectionstring = @"Data Source=DESKTOP-5DQ2HPD\SQLEXPRESS;Initial Catalog=StudentCRUD;Integrated Security=True";

                sqlconnection = new SqlConnection(sqlconnectionstring);
                sqlconnection.Open();


                string user = "name";
                string update = "update student set name = "+ user + "";
                SqlCommand updateQuery = new SqlCommand(update, sqlconnection);

                updateQuery.ExecuteNonQuery();

            Console.WriteLine("updated");  


                sqlconnection.Close();

                Console.ReadKey();

            }
        }
    }


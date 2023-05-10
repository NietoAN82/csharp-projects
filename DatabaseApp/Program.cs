using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace DatabaseApp
{
    class Program
    {

        public static void Main(string[] args)
        {         
            //Connect to the local database
            string connectionString = @"Data Source=AN-DEVICE\SQLEXPRESS;
                                        Initial Catalog=ExampleDatabase;
                                        User ID=Nieto;
                                        Password=;
                                        Trusted_Connection=Yes;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            Debug.WriteLine("Connected to the Server!");
        }
    }
}
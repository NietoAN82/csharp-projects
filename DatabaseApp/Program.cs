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
            //Set up query to send to local database
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM dbo.People";
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    //Access First_Name with GetString(1) and Age with GetString(2)
                    Debug.WriteLine(reader.GetString(1) + "-" + reader.GetString(2));
                }
            }

            connection.Close();
        }
    }
}
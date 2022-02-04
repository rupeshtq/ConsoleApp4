using System;

using System.Data;
using System.Data.SqlClient;

namespace adoExample1
{
    class Class1
    {
   
        
        static void Main(String []args)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString= "Server=DESKTOP-IQ9DH7Q\\SQLEXPRESS;database=HRMSDB;trusted_connection=true";
                con.Open();
                //create command
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "GetDeparmentusingid";
                cmd.Connection = con;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("depid", 10);
                SqlDataReader reader = cmd.ExecuteReader();
                Console.WriteLine("department info through id");
                reader.Read();
                Console.WriteLine(reader[0] + ""+reader[1] + "" + reader[2] + "" + reader[3]);



            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}

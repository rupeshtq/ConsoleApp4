using System;
using System.Data;
using System.Data.SqlClient;

namespace InsertUpadteDeatils
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("Server=DESKTOP-IQ9DH7Q\\SQLEXPRESS;database=MYdb;trusted_connection=true");
                con.Open();

                SqlCommand cmd = new SqlCommand("InsertUpdateEmpData", con);

                cmd.CommandType = CommandType.StoredProcedure;
                Console.WriteLine("Enter empolyee id ");
                int emp_id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter empolyee name ");
                String emp_name = Console.ReadLine();
                Console.WriteLine("Enter email id");
                String email_id = Console.ReadLine();
                Console.WriteLine("Enter empolyee Contact no ");
                String Contact_no = Console.ReadLine();

                Console.WriteLine("Enter empolyee Department ");
                String emp_dept = Console.ReadLine();
                cmd.Parameters.AddWithValue("emp_id", emp_id);
                cmd.Parameters.AddWithValue("emp_name", emp_name);


                cmd.Parameters.AddWithValue("email_id", email_id);
                cmd.Parameters.AddWithValue("Contact_no", Contact_no);
                cmd.Parameters.AddWithValue("deppartment", emp_dept);

                Console.WriteLine("data inser succesfully...");


                cmd.ExecuteNonQuery();
            }

         catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }


            }
        }
    }


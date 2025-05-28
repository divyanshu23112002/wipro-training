using System;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        string connectionString =
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;" +
            "Integrated Security=true";
        int employeeId = 1;
        string newTitle = "Senior Sales Representative";

        string queryString = @"
           Update Employees Set Title=@NewTitle Where EmployeeID=@EmployeeID";

            
            

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand command = new SqlCommand(queryString, connection);
            command.Parameters.AddWithValue("@NewTitle",newTitle);
            command.Parameters.AddWithValue("@EmployeeID", employeeId);


            connection.Open();

           int rowAffected=command.ExecuteNonQuery();
            Console.WriteLine($"{rowAffected} row(s) inserted. ");
            
        }
    }
}
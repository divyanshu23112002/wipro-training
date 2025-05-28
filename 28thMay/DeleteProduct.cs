using System;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        string connectionString =
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;" +
            "Integrated Security=true";
        int productId = 1;
        

        string queryString = @"
           Delete from Products where ProductID=@ProductID";

            
            

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand command = new SqlCommand(queryString, connection);
            command.Parameters.AddWithValue("@ProductID",productId);
            


            connection.Open();

           int rowAffected=command.ExecuteNonQuery();
            Console.WriteLine($"{rowAffected} row(s) deleted. ");
            
        }
    }
}
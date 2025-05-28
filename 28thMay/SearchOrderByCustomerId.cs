using System;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        string connectionString =
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;" +
            "Integrated Security=true";
        string customerId = "PICCO";
        string queryString = @"
            SELECT OrderID, OrderDate 
            FROM Orders where CustomerID=@CustomerID";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand command = new SqlCommand(queryString, connection);
            command.Parameters.AddWithValue("CustomerID",customerId);
            connection.Open();

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Console.WriteLine($"OrderID: {reader["OrderID"]}, " +
                                      $"Date: {reader["OrderDate"]}");
                }
            }
        }
    }
}
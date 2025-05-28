using System;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        string connectionString =
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;" +
            "Integrated Security=true";

        string queryString = @"
            SELECT CustomerID, CompanyName, Country 
            FROM Customers";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand command = new SqlCommand(queryString, connection);
            connection.Open();

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Console.WriteLine($"ID: {reader["CustomerID"]}, " +
                                      $"Name: {reader["CompanyName"]}, " +
                                      $"Country: {reader["Country"]}");
                }
            }
        }
    }
}
using System;
using System.Data;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        string connectionString =
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;" +
            "Integrated Security=true";
        string customerId = "BOLID";
        

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand command = new SqlCommand("CustOrderHist", connection);
            command.CommandType=CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@CustomerID",customerId);
            connection.Open();

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Console.WriteLine($"Product: {reader["ProductName"]}, " +
                                      $"Quantity: {reader["Total"]}");
                }
            }
        }
    }
}
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
           Select o.OrderID , c.CompanyName,o.OrderDate from Orders o inner join Customers c on o.CustomerID=c.CustomerID";


            
            

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand command = new SqlCommand(queryString, connection);
       
            connection.Open();
            using(SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Console.WriteLine($"OrderID: {reader["OrderID"]}, " +
                        $"Company: {reader["CompanyName"]}, " +
                        $"Date: {reader["OrderDate"]}");
                }
            }
            
        }
    }
}
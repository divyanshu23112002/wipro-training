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
            Insert into Products(ProductName,SupplierID,CategoryID,UnitPrice)
            values (@ProductName,@SupplierID,@CategoryID,@UnitPrice)";

            
            

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand command = new SqlCommand(queryString, connection);
            command.Parameters.AddWithValue("@ProductName","Test Product");
            command.Parameters.AddWithValue("@SupplierID", 1);
            command.Parameters.AddWithValue("CategoryID", 1);
            command.Parameters.AddWithValue("@UnitPrice", 25.00);

            connection.Open();

           int rowAffected=command.ExecuteNonQuery();
            Console.WriteLine($"{rowAffected} row(s) inserted. ");
            
        }
    }
}
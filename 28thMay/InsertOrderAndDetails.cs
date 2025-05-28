using System;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        string connectionString =
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;" +
            "Integrated Security=true";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            SqlTransaction transaction = connection.BeginTransaction();

            try
            {
                // Insert Order
                string orderQuery = @"
                    INSERT INTO Orders (CustomerID, OrderDate) 
                    VALUES (@CustomerID, @OrderDate);
                    SELECT SCOPE_IDENTITY();";

                SqlCommand orderCommand = new SqlCommand(orderQuery, connection, transaction);
                orderCommand.Parameters.AddWithValue("@CustomerID", "ALFKI");
                orderCommand.Parameters.AddWithValue("@OrderDate", DateTime.Now);

                int orderId = Convert.ToInt32(orderCommand.ExecuteScalar());

                
                string detailQuery = @"
                    INSERT INTO [Order Details] 
                    (OrderID, ProductID, UnitPrice, Quantity) 
                    VALUES (@OrderID, @ProductID, @UnitPrice, @Quantity)";

                SqlCommand detailCommand = new SqlCommand(detailQuery, connection, transaction);
                detailCommand.Parameters.AddWithValue("@OrderID", orderId);
                detailCommand.Parameters.AddWithValue("@ProductID", 1);
                detailCommand.Parameters.AddWithValue("@UnitPrice", 18.00);
                detailCommand.Parameters.AddWithValue("@Quantity", 2);

                detailCommand.ExecuteNonQuery();

                transaction.Commit();
                Console.WriteLine($"Order {orderId} created successfully!");
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                Console.WriteLine("Transaction failed: " + ex.Message);
            }
        }
    }
}
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

        string queryString = @"
            Select ProductID,ProductName,UnitsInStock from Products where unitsInstock>20";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlDataAdapter adapter = new SqlDataAdapter(queryString, connection);
            DataSet datset = new DataSet();
            adapter.Fill(datset, "Products");

            foreach (DataRow row in datset.Tables["Products"].Rows)
            {
                Console.WriteLine($"ID: {row["ProductID"]}, " +
                    $"Name: {row["ProductName"]}, " +
                    $"Stock: {row["UnitsInStock"]}");
            }
        }
    }
}
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
           Select c.CategoryName,Sum(od.UnitPrice*od.Quantity)As TotalSales
from [Order Details] od inner join Products p ON od.ProductID=p.ProductID
INNER JOIN categories c on p.CategoryID=c.CategoryID group by c.CategoryName";





        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlDataAdapter adapter = new SqlDataAdapter(queryString, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                Console.WriteLine($"Category: {row["CategoryName"]}, " +
                    $"Total Sales: Rs. {row["TotalSales"]}");
            }

        }
    }
}
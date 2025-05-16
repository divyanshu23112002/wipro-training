using System;
using System.Data;
using System.Data.SqlClient;
/*
class Program
{
    static void Main()
    {
        string connectionString =
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=NorthWind;"
            + "Integrated Security=true";

        // Provide the query string with a parameter placeholder.
        string queryString =
            "SELECT ProductID, UnitPrice, ProductName from dbo.products "
                + "WHERE UnitPrice > @pricePoint "
                + "ORDER BY UnitPrice DESC;";

        // Specify the parameter value.
        int paramValue = 5;

        // Create and open the connection in a using block. This
        // ensures that all resources will be closed and disposed
        // when the code exits.
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            // Create the Command and Parameter objects.
            SqlCommand command = new SqlCommand(queryString, connection);
            command.Parameters.AddWithValue("@pricePoint", paramValue);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("\t{0}\t{1}\t{2}",
                        reader[0], reader[1], reader[2]);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
*/
//class SqlConnectionDemo
//{
//    static void Main()
//    {
//        SqlConnection conn=new SqlConnection(
//            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=NorthWind;"
//            + "Integrated Security=SSPI");

//        SqlDataReader rdr=null;

//        try
//        {
//            conn.Open();
//            SqlCommand cmd = new SqlCommand("select * from Customers", conn);

//            rdr = cmd.ExecuteReader();

//            while (rdr.Read())
//            {
//                Console.WriteLine(rdr[1]);
//                ;
//            }
//        }
//        catch { }
//        finally
//        {
//            if (rdr != null)
//            {
//                rdr.Close();
//            }

//            if (conn != null)
//            {
//                conn.Close();

//            }
//        }


//    }
//}

/*
class Program
{
    static void Main()
    {
        string connectionString =
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=NorthWind;"
            + "Integrated Security=true";

        string queryString =
            "SELECT ContactName, City, CompanyName FROM Customers;";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand command = new SqlCommand(queryString, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                // Print headers
                Console.WriteLine("Contact Name\t\t   City\t\t           Company Name");
                Console.WriteLine("-------------\t\t-----------\t\t---------------------");

                while (reader.Read())
                {
                    string contactName = reader["ContactName"].ToString();
                    string city = reader["City"].ToString();
                    string companyName = reader["CompanyName"].ToString();

                    Console.WriteLine("{0,-25} {1,-20} {2,-40}", contactName, city, companyName);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        Console.ReadLine();
    }
}
*/
class Program
{
    static void Main()
    {
        string connectionString =
             "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=NorthWind;"
            + "Integrated Security=true";


        string queryString = @"
            SELECT o.OrderID, e.FirstName, e.LastName, o.OrderDate, o.ShipCity
            FROM Orders o
            INNER JOIN Employees e ON o.EmployeeID = e.EmployeeID
            ORDER BY o.OrderID;";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand command = new SqlCommand(queryString, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                Console.WriteLine("{0,-10} {1,-12} {2,-12} {3,-15} {4,-20}",
                    "OrderID", "First Name", "Last Name", "Order Date", "Ship City");
                Console.WriteLine(new string('-', 70));

                while (reader.Read())
                {
                    Console.WriteLine("{0,-10} {1,-12} {2,-12} {3,-15:dd-MM-yyyy} {4,-20}",
                        reader["OrderID"], reader["FirstName"], reader["LastName"],
                        reader["OrderDate"], reader["ShipCity"]);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        Console.ReadLine();
    }
}
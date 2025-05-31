using System;
using System.Collections.Generic;

public class Product
{
    public string Name { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }

    public double TotalPrice => Price * Quantity;
}

public interface IPrintable
{
    void Print();
}

public abstract class Invoice
{
    public List<Product> Products = new List<Product>();

    public void AddProduct(string name, double price, int quantity)
    {
        Products.Add(new Product { Name = name, Price = price, Quantity = quantity });
    }

    public abstract double CalculateTotal();
}

public class RetailInvoice : Invoice, IPrintable
{
    public override double CalculateTotal()
    {
        double subtotal = 0;
        foreach (var product in Products)
        {
            subtotal += product.TotalPrice;
        }
        double tax = subtotal * 0.1;
        return subtotal + tax;
    }

    public void Print()
    {
        Console.WriteLine("\n--- Retail Invoice ---");
        foreach (var p in Products)
        {
            Console.WriteLine($"{p.Name} - {p.Quantity} x {p.Price} = {p.TotalPrice}");
        }
        Console.WriteLine($"Total (with 10% tax): {CalculateTotal():0.00}");
    }
}

public class WholesaleInvoice : Invoice, IPrintable
{
    public override double CalculateTotal()
    {
        double subtotal = 0;
        foreach (var product in Products)
        {
            subtotal += product.TotalPrice;
        }
        double discount = subtotal * 0.15;
        return subtotal - discount;
    }

    public void Print()
    {
        Console.WriteLine("\n--- Wholesale Invoice ---");
        foreach (var p in Products)
        {
            Console.WriteLine($"{p.Name} - {p.Quantity} x {p.Price} = {p.TotalPrice}");
        }
        Console.WriteLine($"Total (with 15% discount): {CalculateTotal():0.00}");
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter invoice type (retail/wholesale): ");
        string type = Console.ReadLine().ToLower();

        Invoice invoice;
        if (type == "retail")
            invoice = new RetailInvoice();
        else if (type == "wholesale")
            invoice = new WholesaleInvoice();
        else
        {
            Console.WriteLine("Invalid invoice type.");
            return;
        }

        Console.Write("Enter number of products: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nProduct {i + 1}:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Price: ");
            double price = double.Parse(Console.ReadLine());
            Console.Write("Quantity: ");
            int qty = int.Parse(Console.ReadLine());
            invoice.AddProduct(name, price, qty);
        }

        if (invoice is IPrintable printableInvoice)
            printableInvoice.Print();
    }
}
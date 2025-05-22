using System;
using System.Collections.Generic;
class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
}
class Program
{
    static void Main()
    {
        List<Product> products = new List<Product>
       {
           new Product {Id=101,Name="Laptop",Price=75000},
           new Product {Id=102,Name="Mouse",Price=1000},
           new Product {Id=103,Name="SmartPhone",Price=15000},
           new Product {Id=104,Name="Speaker" ,Price=3000},
           new Product {Id=105,Name="Connector ",Price=250}

       };
        var sortProduct = products.OrderByDescending(p => p.Price);
        Console.WriteLine("Products Sorted by Price [High to Low] :");
        foreach(var p in  sortProduct)Console.WriteLine($"{p.Name} - Rs {p.Price}");
    }
}
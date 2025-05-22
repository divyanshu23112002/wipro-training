using System;
using System.Collections.Generic;
class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
}
class Program
{
    static void Main()
    {
        List<Product> products = new List<Product>
       {
           new Product {Name="Laptop",Price=75000},
           new Product {Name="Mouse",Price=1000},
           new Product {Name="SmartPhone",Price=15000},
           new Product {Name="Speaker" ,Price=3000},
           new Product {Name="Connector ",Price=250}

       };
        var exp=products.Where(p=>p.Price>500).ToList();
        Console.WriteLine($"Products with Price Greater than 500");
        foreach (var product in exp) Console.WriteLine($"{product.Name} - Rs {product.Price}");
    }
}
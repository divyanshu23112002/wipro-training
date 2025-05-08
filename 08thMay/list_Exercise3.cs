using System;
using System.Collections;
using System.Collections.Generic;

class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double price {  get; set; }

    public override string ToString()
    {
        return $"ID :  {Id}, Name :  {Name}, Price : {price}";
    }
}

class Program
{
    static void Main()
    {
        List<Product> p = new List<Product>
        {
            new Product { Id = 1,Name="Laptop    ",price=65000 },
            new Product { Id = 2,Name="SmartPhone",price=20000 },
            new Product { Id = 3,Name="HeadPhone ",price=2000 },
            new Product { Id = 4,Name="Speaker   ",price=5000 },
            new Product { Id = 5,Name="Tablet    ",price=10000 }
        };
        p=p.OrderByDescending(pro=>pro.price).ToList();

        Console.WriteLine("Products sorted by price : ");
        foreach(var product in p)Console.WriteLine(product);
        Console.WriteLine("\nProduct with Highest Price : ");
        Console.WriteLine(p.First());

    }
}

using System;
using System.Collections.Generic;
using System.Linq;

public class Item
{
    public string Name { get; set; }
    public string Type { get; set; }
    public int Stock { get; set; }
    public double Price { get; set; }
}

class Program
{
    static void Main()
    {
       
        List<Item> items = new List<Item>
        {
            new Item { Name = "Pen", Type = "Stationery", Stock = 5, Price = 10 },
            new Item { Name = "Notebook", Type = "Stationery", Stock = 2, Price = 50 },
            new Item { Name = "Chair", Type = "Furniture", Stock = 10, Price = 500 },
            new Item { Name = "Table", Type = "Furniture", Stock = 4, Price = 1200 },
            new Item { Name = "Marker", Type = "Stationery", Stock = 1, Price = 30 },
            new Item { Name = "Laptop", Type = "Electronics", Stock = 3, Price = 60000 },
            new Item { Name = "Mouse", Type = "Electronics", Stock = 15, Price = 1200 },
            new Item { Name = "Keyboard", Type = "Electronics", Stock = 10, Price = 2000 },
            new Item { Name = "Bottle", Type = "Utility", Stock = 7, Price = 150 },
            new Item { Name = "Fan", Type = "Electronics", Stock = 2, Price = 3000 },
            new Item { Name = "Whiteboard", Type = "Furniture", Stock = 1, Price = 900 },
            new Item { Name = "Eraser", Type = "Stationery", Stock = 0, Price = 5 },
            new Item { Name = "Desk Lamp", Type = "Electronics", Stock = 5, Price = 2500 },
            new Item { Name = "Stapler", Type = "Stationery", Stock = 6, Price = 60 },
            new Item { Name = "Cup", Type = "Utility", Stock = 3, Price = 80 }
        };

       
        var lowStockItems = items.Where(item => item.Stock < 5).ToList();
        Console.WriteLine("Low Stock Items (Stock < 5):");
        foreach (var item in lowStockItems)
            Console.WriteLine($"{item.Name} - Stock: {item.Stock}");

      
        var groupedItems = items.GroupBy(item => item.Type);
        Console.WriteLine("\nGrouped by Type:");
        foreach (var group in groupedItems)
        {
            Console.WriteLine($"Type: {group.Key}");
            foreach (var item in group)
                Console.WriteLine($"   {item.Name} - Price: {item.Price}");
        }

        
        var highestPricedPerType = groupedItems
            .Select(group => group.OrderByDescending(item => item.Price).First());

        Console.WriteLine("\nHighest Priced Item in Each Type:");
        foreach (var item in highestPricedPerType)
            Console.WriteLine($"{item.Type} - {item.Name}: ₹{item.Price}");
    }
}
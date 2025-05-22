using System;
class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }

    public Product(int id,string name, double price)
    {
        Id = id; Name = name; Price = price;
    }
}
class CarItem
{
    public Product Product { get; set; }
    public int Quantity { get; set; }
    public CarItem(Product product, int quantity)
    {
        Product = product;
        Quantity = quantity;
    }
    public double GetTotalPrice()
    {
        return Product.Price*Quantity;
    }
}
class ShoppingCart
{
    private List<CarItem>items= new List<CarItem>();
   public void AddItem(Product product,int quantity)
    {
        items.Add(new CarItem(product, quantity));
    }
    public void RemoveItem(int productId)
    {
        items.RemoveAll(item=>item.Product.Id==productId);
    }
    public double GetCartTotal()
    {
        double total = 0;
        foreach(var item in items)
        {
            total += item.GetTotalPrice();
        }
        return total;
    }
    public void ShowCart()
    {
        Console.WriteLine("Car Content:");
        foreach(var item in items)
        {
            Console.WriteLine($"{item.Product.Name} X {item.Quantity} = Rs. {item.GetTotalPrice()}");
        }
    }
}
class Program
{
    static void Main()
    {
        Product p1 = new Product(1, "Laptop", 700000);
        Product p2 = new Product(2, "Tablet", 20000);
        Product p3 = new Product(3, "SmartPhone", 30000);
        ShoppingCart cart = new ShoppingCart();
        cart.AddItem(p1, 1);
        cart.AddItem(p2, 2);
        cart.AddItem(p3, 3);

        cart.ShowCart();

        Console.WriteLine($"Total Cart Value: Rs. {cart.GetCartTotal()}");
    }
}
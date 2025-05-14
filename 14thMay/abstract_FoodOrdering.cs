using System;

public abstract class FoodOrder
{
    public void OrderInfo()
    {
        Console.WriteLine("Placing food Order");
    }
    public abstract void PlaceOrder(string item);
}
public class FastFoodOrder:FoodOrder
{
    public override void PlaceOrder(string item)
    {
        Console.WriteLine($"Order Placed for {item} at Fast Food Outlet");
    }
}
public class FineDiningOrder : FoodOrder
{
    public override void PlaceOrder(string item)
    {
        Console.WriteLine($"Order Placed for {item} at FineDining Resturant");
    }
}
class program
{
    static void Main()
    {
        FoodOrder food;
        food=new FastFoodOrder();
        food.OrderInfo();
        food.PlaceOrder("Pizza");

        Console.WriteLine();

        food=new FineDiningOrder();
        food.OrderInfo();
        food.PlaceOrder("Pasta");
    }
}
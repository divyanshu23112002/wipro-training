using System;
public interface Iorder
{
    void PlaceOrder(string item);
    void CancelOrder(string item);
}
public class DineInOrder : Iorder
{
    public void PlaceOrder(string item)
    {
        Console.WriteLine($"Placing dine-in-order for {item}");
    }
    public void CancelOrder(string item)
    {
        Console.WriteLine($"Cancelling dine-in-order for {item}");
    }
}
public class TakeawayOrder:Iorder
{
    public void PlaceOrder(string item)
    {
        Console.WriteLine($"Placing take-away order for {item}");
    }
    public void CancelOrder(string item)
    {
        Console.WriteLine($"Cancelling take-away order for {item}");
    }

}
class Program
{
    static void Main()
    {
        Iorder order;
        order=new DineInOrder();
        order.PlaceOrder("Samosa");
        order.CancelOrder("Samosa");

        Console.WriteLine();

        order=new TakeawayOrder();
        order.PlaceOrder("Pizza");
        order.CancelOrder("Pizza");
    }
}
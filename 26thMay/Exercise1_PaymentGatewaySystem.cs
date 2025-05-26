using System;
public interface IPaymentPocessor
{
    void ProcessPayment (double amount);
}
public abstract class PaymentGateway
{
    public string GatewayName {  get; set; }
    public PaymentGateway(string name)
    {
        GatewayName = name;
    }
    public virtual bool Validate()
    {
        Console.WriteLine($"{GatewayName}: Performing basic validation...");
        return true;
    }
}
public class Razorpay:PaymentGateway,IPaymentPocessor
{
    public Razorpay() : base("Razorpay") { }
    public void ProcessPayment(double amount)
    {
        if(Validate())
        {
            Console.WriteLine($"{GatewayName}: Processing Razorpay payment of Rs. {amount}");
        }
    }
}
public class PayPal:PaymentGateway,IPaymentPocessor
{
    public PayPal() : base("PayPal") { }
    public void ProcessPayment(double amount)
    {
        if(Validate())
        {
            Console.WriteLine($"{GatewayName}: Processing PayPal payment of Rs. {amount}");
        }
    }
}
public class Stripe:PaymentGateway,IPaymentPocessor
{
    public Stripe() : base("PayPal") { }
    public void ProcessPayment(double amount)
    {
        if (Validate())
        {
            Console.WriteLine($"{GatewayName}: Processing PayPal payment of Rs. {amount}");
        }
    }
}
class Program
{
    static void Main()
    {
        List<IPaymentPocessor> pocessors = new List<IPaymentPocessor>
        {
            new Razorpay(),
            new PayPal(),
            new Stripe()
        };
        double[] amount = { 1000.20, 699.99, 20001.10 };
        for(int i=0;i<pocessors.Count;i++)
        {
            pocessors[i].ProcessPayment(amount[i]);
            Console.WriteLine();
        }
    }
}
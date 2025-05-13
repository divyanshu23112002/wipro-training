using System;

public abstract class PaymentGateway
{
    public void ShowGatewayName()
    {
        Console.WriteLine("Processing payment through gateway");
    }
    public abstract void ProcessPayment(double amount);
}
public class StripeGateway:PaymentGateway
{
    public override void ProcessPayment(double amount)
    {
        Console.WriteLine($"Processing payment through Stripe : ${amount}");
    }
}
public class PayPalGateway:PaymentGateway
{
    public override void ProcessPayment(double amount)
    {
        Console.WriteLine($"Processing payment through PayPal: ${amount}");
    }
}
class Program
{
    static void Main()
    {
        PaymentGateway payment;
        payment=new StripeGateway();
        payment.ShowGatewayName();
        payment.ProcessPayment(150.75);

        Console.WriteLine();

        payment=new PayPalGateway();
        payment.ShowGatewayName();
        payment.ProcessPayment(100.25);
    }
}
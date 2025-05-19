using System;
public abstract class PaymentMethod
{
    public void ShowPaymentMethod(string method)
    {
        Console.WriteLine($"Payment Method: {method}");
    }
    public abstract void ProcessPayment(decimal amount);
}
public class CreditCardPayment:PaymentMethod
{
    public override void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing credit card payment of ${amount}");
    }
}
public class UPIPayment:PaymentMethod
{
    public override void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing UPI payment of ${amount}");
    }
}
class Program
{
    static void Main()
    {
        PaymentMethod payment;
        payment=new CreditCardPayment();
        payment.ShowPaymentMethod("Credit Card");
        payment.ProcessPayment(25000.70M);
        Console.WriteLine();

        payment=new UPIPayment();

        payment.ShowPaymentMethod("UPI");
        payment.ProcessPayment(1000.85m);
    }
}
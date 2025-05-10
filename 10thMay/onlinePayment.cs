//Online Payment System

using System;

public class Payment
{
    public decimal Amount;
    public string currency;

    public virtual void ProcessingPayment()
    {
        Console.WriteLine($"Processing payment of {Amount} {currency}");
    }
    public void ProcessingPayment(decimal amount)
    {
        Console.WriteLine($"Processing Payment of {amount} USD (default currency)");
    }
    public void ProcessingPayment(decimal amount, string currency)
    {
        Console.WriteLine($"Processing payment of {amount} {currency}");
    }
}
public class CreditCard:Payment
{
    public string cardNumber;

    public override void ProcessingPayment()
    {
        Console.WriteLine($"Processing Credit Card Payment of {Amount} {currency} using card Number : {cardNumber}");
    }

}
public class payPalPayment:Payment
{
    public string emailAddress;

    public override void ProcessingPayment()
    {
        Console.WriteLine($"Processing PayPal payment of {Amount} {currency} usin Email: {emailAddress}");
    }
}

public class Program
{
    public static void Main()
    {
        CreditCard card = new CreditCard();
        card.Amount= 100.20m;
        card.currency = "USD";
        card.cardNumber = "1234-5678-9012-3456";
        card.ProcessingPayment();

        payPalPayment pp=new payPalPayment();
        pp.Amount = 99.90m;
        pp.currency = "EUR";
        pp.emailAddress = "abc123@gmail.com";
        pp.ProcessingPayment();

        Console.WriteLine("\n\nUsing Overloaded Methods from Base class: ");
        Payment p=new Payment();
        p.ProcessingPayment(1000);

        p.ProcessingPayment(300,"INR");
    }
}
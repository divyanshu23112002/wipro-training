interface IPayment
{
    void ProcessPayment(decimal amount);
}

//Implementing the Interface

class CreditCardPayment:IPayment
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing credit card payment of {amount}");
    }
}

class PayPalPayment:IPayment
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Proceesing PayPal Payment of {amount}");
    }
}

class Program
{
    static void Main()
    {
        IPayment payment;

        payment=new CreditCardPayment();
        payment.ProcessPayment(1500.50m);

        payment=new PayPalPayment();
        payment.ProcessPayment(2500.75m);
    }
}
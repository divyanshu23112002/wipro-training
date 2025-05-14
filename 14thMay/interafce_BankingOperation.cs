public class SavingAccount:IBankAccount
{
    private double balance = 0;
    public void Deposit(double amount)
    {
        balance += amount;
        Console.WriteLine($"Deposited {amount} to Saving Account.");
    }
    public void Withdrawl(double amount)
    {
        if(amount<=balance)
        {
            balance = balance-amount;
            Console.WriteLine($"Withdrew {amount} from Saving Account.");
        }
        else
        {
            Console.WriteLine("Insufficient balance in Saving Account");
        }
    }
    public void CheckBalance()
    {
        Console.WriteLine($"Saving Account Balance : {balance}");   
    }
}
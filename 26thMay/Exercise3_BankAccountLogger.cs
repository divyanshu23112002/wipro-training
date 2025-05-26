using System;
public class Transaction
{
    public DateTime Date { get; set; }
    public string Type { get; set; }

    public double Amount { get; set; }

    public override string ToString()
    {
        return $"{Date} | {Type} | {Amount}";
    }
    public static Transaction FromString(string line)
    {
        var parts=line.Split(' ');
        return new Transaction
        {
            Date = DateTime.Parse(parts[0]),
            Type = parts[1],
            Amount = double.Parse(parts[2])
        };
    }
}
public class BankAccount
{
    public double Balance { get; private set; }
    public List<Transaction> Transactions { get; private set; }
    private readonly string filePath = "TextFile.txt";

    public BankAccount()
    {
        Transactions = new List<Transaction>();
        LoadTransaction();
    }
    public void Deposit(double amount)
    {
        Balance += amount;
        AddTransaction("Deposit", amount);
    }
    public void Withdraw(double amount)
    {
        if (amount <= Balance)
        {
            Balance -= amount;
            AddTransaction("Withdraw", amount);
        }
        else
        {
            Console.WriteLine("Insufficient Balance");
        }
    }
    private void AddTransaction(string type, double amount)
    {
        var transaction = new Transaction
        {
            Date = DateTime.Now,

            Type = type,
            Amount = amount
        };
        Transactions.Add(transaction);
        File.AppendAllLines(filePath, new[] { transaction.ToString() });
    }
    public void LoadTransaction()
    {
        if (!File.Exists(filePath))
        {
            
            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                var t = Transaction.FromString(line);
                Transactions.Add(t);
                if (t.Type == "Deposit") Balance += t.Amount;
                else if (t.Type == "Withdraw") Balance -= t.Amount;

            }
        }
        else
        {
            File.Create(filePath).Dispose();
        }
    }
    public void ShowSummary()
    {
        Console.WriteLine("\n--- Transaction History");
        foreach (var t in Transactions)
        {
            Console.WriteLine($"{t.Date}: {t.Type} Rs. {t.Amount}");
        }
        Console.WriteLine($"\nCurrent Balance: Rs.{Balance}");
    }
}
class Program
{
    static void Main()
    {
        BankAccount account=new BankAccount();
        account.ShowSummary();
        while (true)
        {
            Console.WriteLine("\n1. Depsoit\n2. Withdraw\n3. Exit");
            Console.WriteLine("Choose Option: ");
            var input=Console.ReadLine();
            if(input == "1")
            {
                Console.WriteLine("Enter amountt to depsoit: ");
                double amt=double.Parse(Console.ReadLine());
                account.Deposit(amt);
            }
            else if(input == "2")
            {
                Console.WriteLine("Enter amount to withdraw: ");
                double amt=double.Parse(Console.ReadLine());
                account.Withdraw(amt);
            }
            else if(input == "3")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid option.");
            }
            account.ShowSummary();
        }
    }
}using System;
public class Transaction
{
    public DateTime Date { get; set; }
    public string Type { get; set; }

    public double Amount { get; set; }

    public override string ToString()
    {
        return $"{Date} | {Type} | {Amount}";
    }
    public static Transaction FromString(string line)
    {
        var parts=line.Split(' ');
        return new Transaction
        {
            Date = DateTime.Parse(parts[0]),
            Type = parts[1],
            Amount = double.Parse(parts[2])
        };
    }
}
public class BankAccount
{
    public double Balance { get; private set; }
    public List<Transaction> Transactions { get; private set; }
    private readonly string filePath = "TextFile.txt";

    public BankAccount()
    {
        Transactions = new List<Transaction>();
        LoadTransaction();
    }
    public void Deposit(double amount)
    {
        Balance += amount;
        AddTransaction("Deposit", amount);
    }
    public void Withdraw(double amount)
    {
        if (amount <= Balance)
        {
            Balance -= amount;
            AddTransaction("Withdraw", amount);
        }
        else
        {
            Console.WriteLine("Insufficient Balance");
        }
    }
    private void AddTransaction(string type, double amount)
    {
        var transaction = new Transaction
        {
            Date = DateTime.Now,

            Type = type,
            Amount = amount
        };
        Transactions.Add(transaction);
        File.AppendAllLines(filePath, new[] { transaction.ToString() });
    }
    public void LoadTransaction()
    {
        if (!File.Exists(filePath))
        {
            
            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                var t = Transaction.FromString(line);
                Transactions.Add(t);
                if (t.Type == "Deposit") Balance += t.Amount;
                else if (t.Type == "Withdraw") Balance -= t.Amount;

            }
        }
        else
        {
            File.Create(filePath).Dispose();
        }
    }
    public void ShowSummary()
    {
        Console.WriteLine("\n--- Transaction History");
        foreach (var t in Transactions)
        {
            Console.WriteLine($"{t.Date}: {t.Type} Rs. {t.Amount}");
        }
        Console.WriteLine($"\nCurrent Balance: Rs.{Balance}");
    }
}
class Program
{
    static void Main()
    {
        BankAccount account=new BankAccount();
        account.ShowSummary();
        while (true)
        {
            Console.WriteLine("\n1. Depsoit\n2. Withdraw\n3. Exit");
            Console.WriteLine("Choose Option: ");
            var input=Console.ReadLine();
            if(input == "1")
            {
                Console.WriteLine("Enter amountt to depsoit: ");
                double amt=double.Parse(Console.ReadLine());
                account.Deposit(amt);
            }
            else if(input == "2")
            {
                Console.WriteLine("Enter amount to withdraw: ");
                double amt=double.Parse(Console.ReadLine());
                account.Withdraw(amt);
            }
            else if(input == "3")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid option.");
            }
            account.ShowSummary();
        }
    }
}
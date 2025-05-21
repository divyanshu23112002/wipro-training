using System;
class Program
{
    static void Coin(int amount)
    {
        int[] deno = { 500, 200, 100, 50, 20, 10, 5, 2, 1 };
        List<int> coinUsed = new List<int>();
        foreach (int coin in deno)
        {
            while (amount >= coin)
            {
                amount -= coin;
                coinUsed.Add(coin);
            }
        }
        Console.WriteLine("Coin Used: ");
        foreach (int coin in coinUsed) Console.WriteLine(coin + " ");
        Console.WriteLine($"\nTotal Coins: { coinUsed.Count}");
    }
    static void Main()
    {
        int amt = 880;
        Coin(amt);
    }
}

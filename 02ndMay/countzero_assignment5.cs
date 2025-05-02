using System;

class Program
{
    // Recursive function to count zeros
    static int CountZeros(int n)
    {
        if (n == 0) return 1;
        if (n < 10)
            return (n == 0) ? 1 : 0;

        return (n % 10 == 0 ? 1 : 0) + CountZeros(n / 10);
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        int res = CountZeros(num);
        Console.WriteLine("Number of zeros: " + res);
    }
}
using System;

class Program
{
    
    static int Fibonacci(int n)
    {
        if (n <= 1)
            return n;
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    static void Main()
    {
        Console.Write("Enter the number of terms for Fibonacci series: ");
        int terms = int.Parse(Console.ReadLine());

        Console.WriteLine("Fibonacci series:");
        for (int i = 0; i < terms; i++)
        {
            Console.Write(Fibonacci(i) + " ");
        }
    }
}
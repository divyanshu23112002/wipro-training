// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

class Program
{
    
    static int SumOfArray(int[] arr, int index)
    {
        if (index < 0)
            return 0;
        return arr[index] + SumOfArray(arr, index - 1);
    }

    static void Main()
    {
        Console.Write("Enter the number of elements: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];
        Console.WriteLine("Enter " + n + " numbers:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        int sum = SumOfArray(arr, n - 1);
        Console.WriteLine("Sum of array elements is: "+ sum);
}
}
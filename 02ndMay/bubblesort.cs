using System;

public class HelloWorld
{
    static void bubble(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    // Swap
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    static void printarray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }

    static void Main()
    {
        int[] num = { 50, 40, 10, 20, 30 };
        Console.WriteLine("Original Array:");
        printarray(num);
        
        bubble(num); // Sorting the array
        
        Console.WriteLine("Sorted Array:");
        printarray(num);
    }
}

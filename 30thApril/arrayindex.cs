using System;

class HelloWorld
{
    static void Main()
    {
        int[] arr = { 10, 20, 30, 40, 50, 60, 70 };
        Console.WriteLine("Enter the number to search:");
        int target = int.Parse(Console.ReadLine()); 
        int index = Array.IndexOf(arr, target);
        Console.WriteLine(index >= 0 ? $"Found at index : {index}" : "Not Found");
    }
}

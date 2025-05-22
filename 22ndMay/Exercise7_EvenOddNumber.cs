using System;
class Program
{
    static void Main()
    {
        List<int> num = new List<int>
       {
           1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18
       };
        var evenNumber=num.Where(n=>n%2==0).ToList();
        var oddNumber=num.Where(n=>n%2!=0).ToList();

        Console.WriteLine("Even Number ");
        foreach (var n in evenNumber) Console.Write(n + " ");
        Console.WriteLine("\n\n\nOdd Number");
        foreach (var n in oddNumber) Console.Write(n + " ");
    }
}
// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter number (1-12): ");
    int n=int.Parse(Console.ReadLine());
    string[] days={"January","February","March","April","May","June","July","August","September","October","November","December"};
   
       
            Console.WriteLine (n>=1 && n<=12 ? days[n-1]: "Invalid");
    }
}
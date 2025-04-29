// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter number (1-7): ");
    int n=int.Parse(Console.ReadLine());
    string[] days={"Sunday","Monday","Tuesday","Wednesday","Thrusday","Friday","Saturday"};
   
       
            Console.WriteLine (n>=1 && n<=7 ? days[n-1]: "Invalid");
    }
}
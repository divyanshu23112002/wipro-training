// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number : ");
        int n=int.Parse(Console.ReadLine());
        int rev=0;
        while(n!=0){
            int d=n%10;
            rev=rev*10+d;
            n/=10;
        }
        Console.WriteLine(rev);
    }
}
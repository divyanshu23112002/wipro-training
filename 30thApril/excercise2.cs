// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number : ");
        int n=int.Parse(Console.ReadLine());
        int sum=0;
        while(n!=0){
            sum+=n%10;
            n/=10;
        }
        Console.WriteLine(sum);
    }
}
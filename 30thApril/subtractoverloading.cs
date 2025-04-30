// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    static int subtract(int a,int b){
        return a-b;
    }
    static double subtract(double a,double b){
        return a-b;
    }
     static void Main()
    {
        Console.WriteLine("Int subtract :"+subtract(31,4));
        Console.WriteLine("Double subtract :"+subtract(32.5,4.7));
       
    }
}
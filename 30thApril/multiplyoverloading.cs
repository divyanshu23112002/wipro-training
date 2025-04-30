// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    static int multiply(int a,int b){
        return a*b;
    }
    static double multiply(double a,double b){
        return a*b;
    }
     static void Main()
    {
        Console.WriteLine("Int multiply :"+multiply(31,4));
        Console.WriteLine("Double multiply :"+multiply(32.5,4.7));
       
    }
}
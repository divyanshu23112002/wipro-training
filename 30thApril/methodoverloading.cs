// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    static int add(int a,int b){
        return a+b;
    }
    static double add(double a,double b){
        return a+b;
    }
     static void Main()
    {
        Console.WriteLine("Int Add :"+add(3,4));
        Console.WriteLine("Double Add :"+add(3.5,4.7));
       
    }
}
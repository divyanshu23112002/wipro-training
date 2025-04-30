// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    static int add(int a,int b)=>a+b;
    static int sub(int a,int b)=>a-b;
    static int mul(int a,int b)=>a*b;
    static double div(int a,int b)=>(b==0)? 0: (double)a/b;
    
    

static void Main(){
    Console.WriteLine("Add :"+add(31,4));
    Console.WriteLine("Subtaction :"+sub(31,4));
    Console.WriteLine("Multiply :"+mul(31,4));
    Console.WriteLine("Divide:"+div(10,5));
    
}
}
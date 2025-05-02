// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld

{
    static int factorial(int n){
        if(n==0)return 1;
        return n* factorial(n-1);
      
        
    }
    static void Main()
    {
       int num=10;
       int res=factorial(num);
       Console.WriteLine("Factorial of "+num+" is : "+res);
    }
}
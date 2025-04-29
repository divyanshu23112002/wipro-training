// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

 class HelloWorld
{
    static bool iseven(int n){
        return (n%2==0);
    
    }
    
     static void Main()
    
    {
        int n=21;
       if(iseven(n)==(true)) Console.WriteLine("Number is Even");
        else Console.WriteLine("Number is odd");
        
        
    }
}
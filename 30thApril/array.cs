// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

class HelloWorld
{
     static void printarray(int[] arr)
    {
        for(int i=0;i<arr.Length;i++) {
        Console.WriteLine ($"Element {i+1}: {arr[i]}");
    }
}
static void Main(){
    int[] num={10,20,30,40,50};
    printarray(num);
}
}
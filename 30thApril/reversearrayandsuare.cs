// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

class HelloWorld
{
     static void printarray(int[] arr)
    {   
        for(int i = arr.Length - 1; i >= 0; i--) {
            int square = arr[i] * arr[i];
        Console.WriteLine ($"Square of Element {i + 1} ({arr[i]}): {square}");
    }
}
static void Main(){
    int[] num={10,20,30,40,50};
    printarray(num);
}
}
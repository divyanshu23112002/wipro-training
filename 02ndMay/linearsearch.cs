// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    static int Linear(int[] arr,int target){
        for(int i=0;i<arr.Length;i++){
            if(arr[i]==target)return i;
        }
        return -1;
    }
   static void Main()
    {
        int[] num={10,20,30,40,50};
        int target=30;
        int res=Linear(num,target);
        if(res!=-1) 
        Console.WriteLine ($"Element {target} found at index {res}");
        else 
        Console.WriteLine ($"Element {target} not found at index in an array");
        
    }
}
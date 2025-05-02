// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld

{
    static void findpairsum(int[] arr,int target){
        for(int i=0;i<arr.Length;i++){
            for(int j=i+1;j<arr.Length;j++){
                if(arr[i]+arr[j]==target){
                    Console.WriteLine($"{arr[i]}+{arr[j]}={target}");
                }
            }
        }
        
    }
    static void Main()
    {
       int[] num={2,4,3,5,7};
       int target=9;
       findpairsum(num,target);
    }
}
// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    static int binary(int[] arr,int target){
        int low=0;
        int high=arr.Length-1;
        while(low<=high){
            int mid=(low+high)/2;
            if(arr[mid]==target)return mid;
            else if (arr[mid]<target) low=mid+1;
            else high=mid-1;
        }
        return -1;
    }
   static void Main()
    {
        int[] num={10,20,30,40,50};
        int target=30;
        int res=binary(num,target);
        if(res!=-1) 
        Console.WriteLine ($"Element {target} found at index {res}");
        else 
        Console.WriteLine ($"Element {target} not found at index in an array");
        
    }
}
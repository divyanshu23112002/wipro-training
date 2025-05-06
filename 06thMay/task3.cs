using System;
class Program
{
    static void Main()
    {
        int[] num = { 10, 25, 30, 5, 60 };
        int secondL=largest(num,0,int.MinValue,int.MinValue);
        Console.WriteLine(secondL); 

    }
    static int largest(int[] arr,int index,int l,int secondL)
    {
        if(index==arr.Length) return secondL;
        int curr=arr[index];
        if (curr > l)
        {
            secondL = l;
            l= curr;
        }
        else if(curr>secondL && curr != l)
        {
            secondL = curr;
        }
        return largest(arr, index+1, l, secondL);
        
        
    }
}
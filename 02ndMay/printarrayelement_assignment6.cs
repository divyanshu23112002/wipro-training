using System;

public class HelloWorld
{
    static void PrintArray(int[] arr,int index)
    {
       if(index>=arr.Length)return;
       Console.Write(arr[index]+" ");
       PrintArray(arr,index+1);
       
    }

    static void Main()
    {
        Console.WriteLine("Enter the Number of Elements : ");
        int num=int.Parse(Console.ReadLine());
        int[] arr=new int[num];
        Console.WriteLine("Enter "+num+" Elements : ");
        for(int i=0;i<num;i++){
            arr[i]=int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Array of Element are : ");
        PrintArray(arr,0);
       
    }
}

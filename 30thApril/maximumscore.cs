using System;

class HelloWorld
{
    static int findmax(int[] arr){
        int max=arr[0];
        for(int i=1;i<arr.Length;i++){
            if(arr[i]>max)
                max=arr[i];
        }
            return max;
        
    }
    
    static void Main()
    {
        int[] score={45,57,78,90,21};
        Console.WriteLine("Max Score : "+findmax(score));
        
    }
}

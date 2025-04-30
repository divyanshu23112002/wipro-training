using System;

class HelloWorld
{
    static void Main()
    {
        int[] arr = { 10, 20, 30, 40, 50, 50,60 };
       int[] unique=new int[arr.Length];
       int k=0;
       for(int i=0;i<arr.Length;i++){
           bool isdup=false;
           for(int j=0;j<k;j++){
               if(arr[i]==unique[j]){
                   isdup=true;
                   break;
               }
           }
           if(!isdup){
               unique[k]=arr[i];
               k++;
           }
       }
       Console.WriteLine("Array without Duplicates :");
       for(int i=0;i<k;i++)
       Console.Write(unique[i]+" ");
    }
}

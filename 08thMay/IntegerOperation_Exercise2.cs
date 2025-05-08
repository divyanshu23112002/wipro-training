using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        ArrayList num=new ArrayList();
        Random r=new Random();

        for (int i = 0; i < 10; i++) num.Add(r.Next(1, 51));

        Console.WriteLine("Original List : ");
        foreach(int n in num)Console.WriteLine(n+" ");
        Console.WriteLine();

        num.Sort();

        Console.WriteLine("\nSorted List : ");
        foreach (int n in num) Console.WriteLine(n+" ");
        Console.WriteLine();

        int min=(int)num[0];
        int max = (int)num[num.Count-1];
        Console.WriteLine($"\nMinimum Values : {min}");
        Console.WriteLine($"Maximum Values : {max}");

        int sum = 0;
        foreach(int n in num)sum+= n;
        double avg=(double)sum/num.Count;
        Console.WriteLine($"Average Value : {avg:F2}");


    }
}

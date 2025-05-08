using System;
using System.Collections;
using System.Collections.Generic;



class Program
{
    static void Main()
    {
        List<int> num = new List<int> { 10, 20, 10, 30, 50, 60, 20, 70, 40, 60, 80 };

        HashSet<int> unique = new HashSet<int>(num);
        Console.WriteLine("Unique Numbers : ");
        foreach(int n in unique) Console.WriteLine(n+" ");

        Console.WriteLine($"\nTotal Unique Elements : {unique.Count}");

    }
}

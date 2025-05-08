using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> n = new List<int> { 20, 40, 60, 80, 100 };
        int index=n.IndexOf(20);
        Console.WriteLine("Index of 20 : "+index);

        bool contain = n.Contains(40);
        Console.WriteLine("Constains of 40 : "+contain);
    }
}
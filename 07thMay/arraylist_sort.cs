using System;
using System.Collections;
class Program
{
    static void Main()
    {
        ArrayList num = new ArrayList() { 4, 1, 8, 3 };
        num.Sort();
        Console.WriteLine("Sorted : ");
        foreach (var n in num)
        {
            Console.WriteLine(n);
        }
        num.Reverse();
        Console.WriteLine("Rversed : ");
        foreach (var n in num)
        {
            {
                Console.WriteLine(n);
            }
        }

    }
}
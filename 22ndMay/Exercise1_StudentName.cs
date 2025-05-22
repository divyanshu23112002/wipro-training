using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        List<string>students=new List<string>();
        students.Add("Ram");
        students.Add("Shyam");
        students.Add("Mohan");
        students.Add("Rohan");
        students.Add("Sohan");

        Console.WriteLine("Original List: ");
        foreach(var name in students)Console.WriteLine(name);
        var sort=students.OrderBy(name => name).ToList();
        Console.WriteLine("\n\nSorted List: ");
        foreach (var name in sort) Console.WriteLine(name);
    }
}
using System;
using System.Collections;
class Program
{
    static void Main()
    {
        ArrayList list = new ArrayList();
        list.Add("Apple");
        list.Add(4);
        list.Add(5.14);
        if (list.Contains("Apple")) Console.WriteLine("Found Apple in the list");
        else Console.WriteLine("Not Found");
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
        Console.Read();
    }

}
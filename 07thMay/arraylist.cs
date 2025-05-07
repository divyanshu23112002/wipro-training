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
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
        Console.Read();
    }
    
}
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
        list.Remove(4);
        list.RemoveAt(0);
        Console.WriteLine("Count After Removal " + list.Count); //output: Inserted
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
        Console.Read();
    }
    
}
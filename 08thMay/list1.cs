using System;
using System.Collections;
class Program
{
    static void Main()
    {

        List<string> fruits = new List<string>() { "Apple", "Banana", "Cherry" };

        //Adding an elements
        fruits.Add("Mango");

        fruits.Remove("Banana");

        fruits.RemoveAt(2);

        if (fruits.Contains("Apple")) Console.WriteLine("Apple is in the list");

        fruits.Sort();

        Console.WriteLine("Fruits List : ");

        foreach(string fruit in fruits) Console.WriteLine(fruit);

    }
}
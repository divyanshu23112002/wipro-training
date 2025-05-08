using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //creatin a dictionary to store student IDs and names
        Dictionary<string, string> cities = new Dictionary<string, string>

       {
            {"Mumbai","Marashtra" },
            {"Banalore","Karnatka" },
            {"Chennai","Tamil Nadu" },
            {"Kolkata","West Bengal" },
            {"Hyderabad","Telanana" }
       };


        Console.WriteLine("Indian Cities and their states : ");
        foreach(var c in cities) Console.WriteLine($"{c.Key} is in {c.Value}");

        if (cities.ContainsKey("Chennail")) Console.WriteLine("Chennai is in the dictionary");

    }
}
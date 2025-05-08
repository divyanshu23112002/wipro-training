using System;
using System.Collections;
using System.Collections.Generic;



class Program
{
    static void Main()
    {
        Dictionary<string,string> phoneD=new Dictionary<string, string>();
        phoneD.Add("Ram", "7654315678");
        phoneD.Add("Shyam", "9876543219");
        phoneD.Add("Mohan", "6547832019");
        phoneD.Add("Rohan", "8765897640");
        phoneD.Add("Sohan", "9008855330");

        phoneD["Mohan"] = "7659088442";

        string check = "Ram";
        if (phoneD.ContainsKey(check)) Console.WriteLine($"{check} Exists in the directory with number {phoneD[check]}.");
        else Console.WriteLine($"{check} does not exists in the directory");

        Console.WriteLine("\nPhone Directory : ");

        foreach(var  phone in phoneD)Console.WriteLine($"{phone.Key}: {phone.Value}");

    }
}

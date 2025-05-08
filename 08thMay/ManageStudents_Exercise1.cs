using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        ArrayList name=new ArrayList();
        name.Add("Ram");
        name.Add("Shyam");
        name.Add("Sohan");
        name.Add("Rohan");
        name.Add("Mohan");

        name.Remove("Sohan");

        Console.WriteLine("List of Students After Removal : ");

        foreach(var n in name)Console.WriteLine(n);

        string check = "Ram";
        if(name.Contains(check))Console.WriteLine($"\n{check} Exists in the list");

        else Console.WriteLine($"\n{check}does not Exists in the list");



    }
}

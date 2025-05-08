using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
       //creatin a dictionary to store student IDs and names
       Dictionary<int,string> students = new Dictionary<int,string>();

        //Addin Elements
        students.Add(101, "Alice");
        students.Add(102, "Bob");
        students.Add(103, "Charlie");

        //Accessing values in row
        Console.WriteLine("Students with ID 102 : "+students[102]);

        //Loping through the dictionary
        foreach(var pair in students) Console.WriteLine($"ID :{pair.Key},Name: {pair.Value}");  

    }
}
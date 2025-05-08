using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //creatin a dictionary to store student IDs and names
        Dictionary<int, string> employee = new Dictionary<int, string>

       {
           {1,"Rohit" },
           {2,"Anjali" },
           {3,"Sandeep" }
       };


        //Updating the name of employee
        employee[2] = "Ananya";

        Console.WriteLine("Updated Employee list : ");

        //Loping through the dictionary
        foreach(var emp in employee) Console.WriteLine($"ID :{emp.Key},Name: {emp.Value}");  

    }
}
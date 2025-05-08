using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> employee = new List<string>();

        //Adding 5 employee Name
        employee.Add("Ram Kumar");
        employee.Add("Sunil Singh");
        employee.Add("Mohan Kumar");
        employee.Add("Sohan Kumar");
        employee.Add("Rohan Kumar");

        //Remove a employee name
        employee.Remove("Ram Kumar");


        //check Sohan Kumar exists in list 
        if (employee.Contains("Sohan Kumar")) Console.WriteLine("Sohan Kumar is in the list");
        else Console.WriteLine("Not in list");

         employee.Sort();

        //List of Employee
        Console.WriteLine($"Total number of Employees : {employee.Count}");
        Console.WriteLine("Employee List : ");

        foreach (string emp in employee) Console.WriteLine(emp);
    }
}
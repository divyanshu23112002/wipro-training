using System;
using System.Collections.Generic;
using System.Linq;

public class Employee
{
    public int EmployeeID { get; set; }
    public string Name { get; set; }
    public decimal Salary { get; set; }

    public Employee(int id, string name, decimal salary)
    {
        EmployeeID = id;
        Name = name;
        Salary = salary;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee(101, "Ram Kumar", 55000),
            new Employee(102, "Shyam Kumar", 48000),
            new Employee(103, "Mohan Kumar", 62000),
            new Employee(104, "Sohan Kumar", 59000),
            new Employee(105, "Rohan Kumar", 61000)
        };

       
        Employee highestPaid = employees.OrderByDescending(e => e.Salary).First();
        Console.WriteLine($"Highest Paid Employee: {highestPaid.Name}, Salary: {highestPaid.Salary}");

        Console.WriteLine();

      
        Dictionary<int, string> employeeDirectory = new Dictionary<int, string>();
        foreach (var emp in employees)
        {
            employeeDirectory[emp.EmployeeID] = emp.Name;
        }

       
        Console.WriteLine("Employee Directory:");
        foreach (var entry in employeeDirectory)
        {
            Console.WriteLine($"ID: {entry.Key}, Name: {entry.Value}");
        }

        Console.WriteLine();

       
        Console.Write("Enter Employee ID to search: ");
        int searchId = Convert.ToInt32(Console.ReadLine());

        if (employeeDirectory.ContainsKey(searchId))
        {
            Console.WriteLine($"Employee found: {employeeDirectory[searchId]}");
        }
        else
        {
            Console.WriteLine("Employee ID not found.");
        }
    }
}
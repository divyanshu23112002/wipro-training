using System;
using System.Collections.Generic;
using System.Linq;

public class Employee
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public decimal Salary { get; set; }

    public Employee(int id, string name, string department, decimal salary)
    {
        ID = id;
        Name = name;
        Department = department;
        Salary = salary;
    }
}

class Program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee(1, "Ram Kumar", "HR", 50000),
            new Employee(2, "Shyam Kumar", "IT", 70000),
            new Employee(3, "Mohan Kumar", "HR", 55000),
            new Employee(4, "Sohan Kumar", "IT", 80000),
            new Employee(5, "Sita", "Finance", 60000),
            new Employee(6, "Gita", "IT", 75000)
        };

        Console.Write("Enter department to filter (e.g. IT, HR, Finance): ");
        string inputDept = Console.ReadLine();

        var filtered = employees.Where(e => e.Department.Equals(inputDept, StringComparison.OrdinalIgnoreCase)).ToList();
        Console.WriteLine($"\nEmployees in {inputDept} Department:");
        foreach (var emp in filtered)
        {
            Console.WriteLine($"{emp.ID} - {emp.Name} - Rs. {emp.Salary}");
        }

        var sortedBySalary = employees.OrderByDescending(e => e.Salary).ToList();
        Console.WriteLine("\nEmployees sorted by salary (descending):");
        foreach (var emp in sortedBySalary)
        {
            Console.WriteLine($"{emp.Name} ({emp.Department}) - ₹{emp.Salary}");
        }

        var avgSalaryPerDept = employees
            .GroupBy(e => e.Department)
            .Select(g => new
            {
                Department = g.Key,
                AverageSalary = g.Average(e => e.Salary)
            });

        Console.WriteLine("\nAverage Salary per Department:");
        foreach (var dept in avgSalaryPerDept)
        {
            Console.WriteLine($"{dept.Department}: ₹{dept.AverageSalary:F2}");
        }
    }
}
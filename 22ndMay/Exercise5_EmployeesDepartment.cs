using System;
using System.Collections.Generic;
class Employee
{
    public string Name { get; set; }
    public string Department { get; set; }
}
class Program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>
       {
           new Employee {Name="Ram",Department="IT"},
           new Employee {Name="Shyam",Department="Finance"},
           new Employee {Name="Mohan",Department="HR"},
           new Employee {Name="Sohan" ,Department="Manager"},
           new Employee {Name="Rohan",Department="HR"}

       };
        var groupedByDepart = employees.GroupBy(e => e.Department);
        foreach (var group in groupedByDepart)
        { Console.WriteLine($"Department :{group.Key}");
            foreach (var emp in group) Console.WriteLine($" - {emp.Name}");
                }
    }
}
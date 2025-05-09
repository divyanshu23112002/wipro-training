using System;

public class Employeee
{
    private int id;
    private string name;
    private string department;
    private double salary;

    public Employeee(int id, string name, string department, double salary)
    {
        this.id = id;
        this.name = name;
        this.department = department;
        this.salary = salary;
    }

    public void printDetails()
    {
        Console.WriteLine($"Employee ID : {id}");
        Console.WriteLine($"Name : {name}");
        Console.WriteLine($"Department :{department}");
        Console.WriteLine($"Monthly Salary : {salary}");
    }
    public void UpdateSalary(double newSalary)
    {
        salary = newSalary;
    }
    public double AnnualSalary()
    {
        return salary * 12;
    }

    public static void Main()
    {
        Employeee emp1 = new Employeee(101, "Ram Kumar", "IT", 45000);
        emp1.printDetails();
        Console.WriteLine("Annual Salary : " + emp1.AnnualSalary());

        emp1.UpdateSalary(65000);
        Console.WriteLine("\nAfter Salary Update");
        emp1.printDetails();
        Console.WriteLine("Annual Salary ; " + emp1.AnnualSalary());
    }
}
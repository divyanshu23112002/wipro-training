using System;
using System.Runtime.CompilerServices;
public abstract class Employee
{
    public void ShowBasicInfo()
    {
        Console.WriteLine("Employee Details");
    }
    public abstract void CalculateSalary();
}
public class FullTimeEmployee:Employee
{
    private double basic = 40000;
    public double allowance = 15000;

    public override void CalculateSalary()
    {
        double tot = basic + allowance;
        Console.WriteLine($"Salary : Basic + Allowance = {basic} + {allowance}={tot}");
    }
}
public class PartTimeEmployee:Employee
{
    private double hourRate = 800;
    private int hourWork = 30;

    public override void CalculateSalary()
    {
        double tot=hourRate * hourWork;
        Console.WriteLine($"Salary : Hourly Rate X Hours Worked = {hourRate} X {hourWork} = {tot}");
    }
}
class program
{
    static void Main()
    {
        Employee emp;

        emp=new FullTimeEmployee();
        emp.ShowBasicInfo();
        emp.CalculateSalary();

        Console.WriteLine();

        emp=new PartTimeEmployee();
        emp.ShowBasicInfo();
        emp.CalculateSalary();  
    }
}
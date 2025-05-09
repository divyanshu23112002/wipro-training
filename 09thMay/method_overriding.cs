using System;

class Employee
{
    public virtual void Work()
    {
        Console.WriteLine("Employee is Working");
    }
}
class Manager:Employee
{
    public override void Work()
    {
        Console.WriteLine("Manager is supervising.");
    }
}

class Program
{
    static void Main()
    {
        Employee emp = new Employee();
        emp.Work();

        Manager mg= new Manager();
        mg.Work();

        Employee polyEmp=new Manager();
        polyEmp.Work();
    }
}
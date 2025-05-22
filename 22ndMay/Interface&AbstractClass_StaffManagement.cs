using System;
public interface IAttendance
{
    void MarkAttendance();
}
public abstract class Staff:IAttendance
{
    public int Id {  get; set; }
    public string Name { get; set; }

    public string Department { get; set; }

    public abstract double CalculateSalary();

    public abstract void MarkAttendance();
}
public class PermanentStaff : Staff
{
    public double BasicSalary {  get; set; }
    public override double CalculateSalary()
    {
        return BasicSalary+(0.2*BasicSalary);
    }
    public override void MarkAttendance()
    {
        Console.WriteLine($"{Name} (Permanent) attendance marked.");

    }
}
public class ContractStaff : Staff
{
    public int HourWork{ get; set; }
    public double HourlyRate {  get; set; }

    public override double CalculateSalary()
    {
        return HourlyRate * HourWork;
    }
    public override void MarkAttendance()
    {
        Console.WriteLine($"{Name} (Permanent) attendance marked.");
    }

}
class Program
{
    static void Main()
    {
        List<Staff>staffList=new List<Staff>();
        PermanentStaff permanent = new PermanentStaff
        {
            Id = 101,
            Name = "Ram Kumar",
            Department = "Computer Science",
            BasicSalary = 50000
        };
        ContractStaff contract = new ContractStaff
        {
            Id = 102,
            Name = "Shyam Kumar",
            Department = "Electrical",
            HourlyRate = 500,
            HourWork = 100
        };
        staffList.Add(permanent);
        staffList.Add(contract);

        foreach(var staff in staffList)
        {
            staff.MarkAttendance();

            Console.WriteLine($"{staff.Name}'s Salary: {staff.CalculateSalary()}");
        }
    }
        }
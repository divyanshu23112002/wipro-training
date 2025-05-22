using System;
class Program
{
    static void Main()
    {
       Dictionary<int,decimal>salary= new Dictionary<int,decimal>();
        salary.Add(101, 50000.50m);
        salary.Add(102, 40000.69m);
        salary.Add(103, 60000.70m);
        salary.Add(104, 80000.80m);
        salary.Add(105, 510000.51m);

        Console.WriteLine("Enter Employee ID :");
        if (int.TryParse(Console.ReadLine(), out int empID))
        {
            if (salary.ContainsKey(empID))
            {
                Console.WriteLine($"Salary of Employee {empID}: Rs {salary[empID]}");
            }
            else
            {
                Console.WriteLine("Employee not Found");
            }
        }
        else Console.WriteLine("Invalid input. Please Enter a valid Employee ID.");

    }
}
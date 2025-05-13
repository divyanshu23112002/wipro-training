
public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }

    public int Age { get; set; }
}

class Program
{
    static void Main(string[] args)

    {
        Employee[] EmpArray = { new Employee() { Id = 1, Name = "John", Age = 19 },
            new Employee() { Id = 2, Name = "Steve", Age = 21 },
            new Employee() { Id = 3, Name = "Bill", Age = 25 },
            new Employee() { Id = 4, Name = "Ram", Age = 20 },
            new Employee() { Id = 5, Name = "Ron", Age = 31 },
            new Employee() { Id = 6, Name = "Chris", Age = 17 },
            new Employee() { Id = 7, Name = "Rob", Age = 19 },
        };

        Employee[] emp = new Employee[10];
        int i = 0;
        foreach (Employee employee in EmpArray)
        {
            if (employee.Age > 12 && employee.Age < 20)
            {
                emp[i] = employee;
                System.Console.WriteLine(employee.Name);
                i++;
            }
        }
    }
}
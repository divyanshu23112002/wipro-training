using System;
using System.Collections.Generic;
class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
}
class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "Alice" },
            new Student { Id = 2, Name = "Bob" }
        };
        students.Add(new Student { Id = 3, Name = "Charlie" });
        foreach (var student in students) Console.WriteLine($"ID: {student.Id},Name :{student.Name}");
    }
}
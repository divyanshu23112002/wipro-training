using System;
using System.Collections.Generic;
class Student
{
    public string Name { get; set; }
    public int Mark { get; set; }
}
class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>
       {
           new Student {Name="Ram",Mark=75},
           new Student {Name="Shyam",Mark=100},
           new Student {Name="Mohan",Mark=80},
           new Student {Name="Sohan" ,Mark=67},
           new Student {Name="Rohan",Mark=25}

       };
        var top = students.OrderByDescending(s => s.Mark).Take(3).ToList();
        foreach (var student in top) Console.WriteLine($"{student.Name} -  {student.Mark} marks");
    }
}
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
        double avg = students.Average(s => s.Mark);
        Console.WriteLine($"Average Marks:{avg}");

        int aboveAvgCount=students.Count(s=>s.Mark>avg);
        Console.WriteLine($"Students Scoring Above Average: {aboveAvgCount}");
    }
}
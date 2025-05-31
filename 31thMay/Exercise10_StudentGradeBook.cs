using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public string Name { get; set; }
    public Dictionary<string, int> Marks { get; set; }

    public double Average => Marks.Values.Average();
    public int Highest => Marks.Values.Max();
    public int Lowest => Marks.Values.Min();
}

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>();

        Console.Write("Enter number of students: ");
        int studentCount = int.Parse(Console.ReadLine());

        Console.Write("Enter number of subjects: ");
        int subjectCount = int.Parse(Console.ReadLine());

        List<string> subjects = new List<string>();
        for (int i = 0; i < subjectCount; i++)
        {
            Console.Write($"Enter subject {i + 1} name: ");
            subjects.Add(Console.ReadLine());
        }

        for (int i = 0; i < studentCount; i++)
        {
            Console.WriteLine($"\nStudent {i + 1}:");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Dictionary<string, int> marks = new Dictionary<string, int>();
            foreach (string subject in subjects)
            {
                Console.Write($"Enter marks for {subject}: ");
                int mark = int.Parse(Console.ReadLine());
                marks[subject] = mark;
            }

            students.Add(new Student { Name = name, Marks = marks });
        }

        Console.WriteLine("\n--- Student Report ---");
        foreach (var student in students)
        {
            Console.WriteLine($"\n{student.Name}");
            foreach (var m in student.Marks)
            {
                Console.WriteLine($"{m.Key}: {m.Value}");
            }
            Console.WriteLine($"Average: {student.Average:0.00}");
            Console.WriteLine($"Highest: {student.Highest}");
            Console.WriteLine($"Lowest: {student.Lowest}");
        }

        var top3 = students.OrderByDescending(s => s.Average).Take(3);

        Console.WriteLine("\n--- Top 3 Scorers ---");
        foreach (var s in top3)
        {
            Console.WriteLine($"{s.Name} - Avg: {s.Average:0.00}");
        }
    }
}
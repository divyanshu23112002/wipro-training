using System;
public class Student
{
    public string Name {  get; set; }

    public int Marks { get; set; }

    public char Grade { get; set; }

    public Student(string name, int marks, char grade)
    {
        Name = name;
        Marks = marks;
        Grade = grade;
    }
}
class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student("Ankit",95,'A'),
            new Student("Ram",80,'B'),
            new Student("Shyan",90,'A'),
            new Student("Mohan",79,'C'),
            new Student("Sohan",71,'C'),
            new Student("Rohan",68,'D'),
            new Student("Gita",99,'A'),
            new Student("Sita",55,'E'),
            new Student("Rita",85,'B'),
            new Student("Ayush",75,'C')
        };
        var sortStudent = students.OrderByDescending(s => s.Marks);
        Console.WriteLine("Students sorted by Marks (Descending):");
        foreach(var s in sortStudent)
        {
            Console.WriteLine($"{s.Name} - Marks: {s.Marks}, grade: {s.Grade}");
        }
        var groupedByGrade=students.GroupBy(s=>s.Grade);
        foreach(var group in groupedByGrade)
        {
            Console.WriteLine($"Grade {group.Key}");
            foreach(var s in group)
            {
                Console.WriteLine($"   {s.Name} - {s.Marks}");
            }
        }
        Console.WriteLine("\nTop 3 Student:");
        var top3 = sortStudent.Take(3);
        foreach(var s in top3)
        {
            Console.WriteLine($"{s.Name} - Marks: {s.Marks}");
        }

    }
}
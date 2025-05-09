using System;

class Student
{
    public int RollNumber;
    public string Name;

    public int marks;

    public void printDetails()
    {
        Console.WriteLine($"Roll Number : {RollNumber}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Marks: {marks}");
    }
}



class Program
{
    static void Main()
    {
       Student s=new Student();

        s.RollNumber = 101;
        s.Name = "Amit";
        s.marks = 86;

        s.printDetails();   

    }
}

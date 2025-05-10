using System;

public class Person
{
    public string name;
    public int age;

    public void ShowInfo()
    {
        Console.WriteLine("Name : " + name);
    Console.WriteLine("Age : "+age);
    
    }
}
public class Student:Person
{
    public int Roll;
    public void ShowStudentInfo()
    {
        Console.WriteLine("Roll Number : "+Roll);
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Student s= new Student();
        s.name = "Ram Kumar";
        s.age = 20;
        s.Roll = 101;
    s.ShowInfo();
    s.ShowStudentInfo();
    }
}
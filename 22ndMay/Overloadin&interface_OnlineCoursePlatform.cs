using System;



public class Course
{
    public int Id { get; set; }
    public string Title { get; set; }
    public double Fee { get; set; }

    public Course(int id, string title, double fee)
    {
        Id = id;
        Title = title;
        Fee = fee;
    }
}


public interface IEnrollable
{
    void Enroll(Course course);
    void Enroll(Course course, string couponCode);
}


public class User : IEnrollable
{
    public string Name { get; set; }
    private List<(Course, double)> enrolledCourses = new List<(Course, double)>();

    public User(string name)
    {
        Name = name;
    }

    public void Enroll(Course course)
    {
        enrolledCourses.Add((course, course.Fee));
        Console.WriteLine($"{Name} enrolled in {course.Title} at full fee: {course.Fee}");
    }

    public void Enroll(Course course, string couponCode)
    {
        double discount = 0;

        if (couponCode == "DISCOUNT10")
            discount = 0.10;
        else if (couponCode == "DISCOUNT20")
            discount = 0.20;

        double finalFee = course.Fee * (1 - discount);
        enrolledCourses.Add((course, finalFee));

        Console.WriteLine($"{Name} enrolled in {course.Title} using {couponCode}, fee after discount: {finalFee}");
    }

    public void ShowEnrolledCourses()
    {
        Console.WriteLine($"\n{Name}'s Enrolled Courses:");
        foreach (var (course, finalFee) in enrolledCourses)
        {
            Console.WriteLine($"- {course.Title} | Final Fee: {finalFee}");
        }
    }
}


class Program
{
    public static void Main()
    {
        Course c1 = new Course(1, "Data Structures", 5000);
        Course c2 = new Course(2, "Machine Learning", 10000);

        User user = new User("Ankit");

        user.Enroll(c1); 
        user.Enroll(c2, "DISCOUNT10"); 

        user.ShowEnrolledCourses();
    }
}
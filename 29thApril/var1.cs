using System;

public class HelloWorld
{
    public static void Main(string[] args)
    
    {
        int age=25;
        string name="Jhon";
        bool isstudent=true;
        double fee=55000.75;
        
        
        //printing values :------->
        // Console.WriteLine ("Name : "+name);
        // Console.WriteLine ("Age : "+age);
        // Console.WriteLine ("Is Studnet : "+isstudent);
        // Console.WriteLine ("Fees : "+fee);
        Console.WriteLine($"Name:{name}");
        Console.WriteLine($"Age:{age}");
        Console.WriteLine($"Is Student:{isstudent}");
        Console.WriteLine($"Fees:{fee}");
        
    }
}
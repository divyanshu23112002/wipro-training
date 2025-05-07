using System;
using System.Collections;
class Program
{
    static void Main()
    {
       
        //create arraylist of the student names
        ArrayList students=new ArrayList();

        //Add 5 names to the list
        students.Add("Ram");
        students.Add("Shyam");
        students.Add("Mohan");
        students.Add("Sohan");
        students.Add("Rohan");


        //check if a specific name exists
        string check = "Mohan";
        if(students.Contains(check))
        {
            Console.WriteLine($"{check} is in the list");
        }
        else
        {
            Console.WriteLine($"{check} is not in the list");
        }

        //remove the second name

        if(students.Count>1)
        {
            students.RemoveAt(1); //remove Shyam
        }

        //Display final List

        Console.WriteLine("\nFinal List of the Students :");
        foreach(var n in students)
        {
            Console.WriteLine(n);
        }

    }
}
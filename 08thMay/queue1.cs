using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //creating a queue of string
        Queue<string> customers = new Queue<string>();

        //Enqueue Elements 
       customers.Enqueue("Amit");
        customers.Enqueue("Neha");
        customers.Enqueue("Ravi");
        
        Console.WriteLine("Serving Elements : ");
        while(customers.Count>0)Console.WriteLine("Serving : "+customers.Dequeue());
       


    }
}

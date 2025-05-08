using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //creating a queue of string
        Queue<string> queue = new Queue<string>();

        //Enqueue Elements 
        queue.Enqueue("Amit");
        queue.Enqueue("Neha");
        queue.Enqueue("Ravi");
        queue.Enqueue("Priya");

        Console.WriteLine("Queue Elements");
        foreach(var name in queue)Console.WriteLine(name);

        //Dequeu the elemets
        Console.WriteLine("\nDequeued : "+queue.Dequeue());

        //peek at the front elemets
        Console.WriteLine("Next in Line : "+queue.Peek());


    }
}
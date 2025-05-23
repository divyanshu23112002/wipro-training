using System;
using System.Threading;
class Program
{
    static void PrintNumber()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"Thread: {i}"); 
            Thread.Sleep(500);  //pause for 0.5 second
        }
    }
    static void Main(string[] args)
    {
        Thread myThread=new Thread(PrintNumber);  //Create a thread
        myThread.Start();   //Start the thread
        for (int i = 1;i <= 5;i++)
        {
            Console.WriteLine($"Main: {i}");
            Thread.Sleep(500);
        }
    }
}
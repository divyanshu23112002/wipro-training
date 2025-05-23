using System;
using System.Threading;
class Program
{
    /*
    static void Printmsg(object meassage)
    {
        // for (int i = 1; i <= 5; i++)
        // {
        //     Console.WriteLine($"Thread: {i}"); 
        //     Thread.Sleep(500);  //pause for 0.5 second
        // }
        string msg = (string)meassage; //Cast to correct type
        Console.WriteLine("Meassage : " + msg);

    }
    */
    static void Main(string[] args)
    {
        // Thread myThread=new Thread(PrintNumber);  //Create a thread
        // myThread.Start();   //Start the thread
        // for (int i = 1;i <= 5;i++)
        // {
        //     Console.WriteLine($"Main: {i}");
        //     Thread.Sleep(500);
        // }
        //Thread thread = new Thread(new ParameterizedThreadStart(Printmsg));
        //thread.Start("Hello from the thread!");

        int a = 5, b = 10;
        Thread thread = new Thread(() =>
        { Console.WriteLine($"Sum: {a + b}"); });
        thread.Start();
    }
}
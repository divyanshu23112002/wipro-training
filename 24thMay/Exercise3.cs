using System;
class ThreadPoolExp
{
    static void ProcessItem(object item)
    {
        Console.WriteLine($"Processing item {item} on thread {Thread.CurrentThread.ManagedThreadId}");
        Thread.Sleep(500);
        Console.WriteLine($"Finished item {item} on thread {Thread.CurrentThread.ManagedThreadId}");

    }
    static void Main()
    {
        Console.WriteLine("Queuing 5 items on ThreadPool...");
        for (int i=1; i <= 5;i++)
        {
            ThreadPool.QueueUserWorkItem(ProcessItem, i);


        }
        Console.WriteLine("Main thread done Queueing items");

        Thread.Sleep(2000);
        Console.WriteLine("All ThreadPool task likely completed.");
    }
}
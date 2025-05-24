using System;

class Program
{
    static async Task Main(string[] args)
    {
        //Console.WriteLine("Work Stated:");
        //await DoAsyncWork();
        //Console.WriteLine("Work Completed");

        Console.WriteLine("Starting all tasks...");
        Task t1 = DoAsyncWork("Task 1", 2000);
        Task t2 = DoAsyncWork("Task 2",3000);
        Task t3 = DoAsyncWork("Task 3", 1000);

        await Task.WhenAll(t1, t2, t3);
        Console.WriteLine("All task Completed");
    }
    static async Task DoAsyncWork(string name,int delay)
    {
        //Console.WriteLine("Working asynchronously");
        //await Task.Delay(2000);  //Simulate 2 Second of delay
        //Console.WriteLine("Async Work Done");

        Console.WriteLine($"{name} started.");
        await Task.Delay(delay);
        Console.WriteLine($"{name} completed after {delay}ms.");
    }
}
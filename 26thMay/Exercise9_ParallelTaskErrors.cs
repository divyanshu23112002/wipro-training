using System;

class Program
{
    static async Task Main()
    {
        Console.WriteLine("Starting parallel tasks...\n");

        List<Task> tasks = new List<Task>();

        for (int i = 1; i <= 5; i++)
        {
            int taskId = i;

           
            tasks.Add(Task.Run(() =>
            {
                if (taskId == 2 || taskId == 4)
                {
                    throw new InvalidOperationException($"Task {taskId} failed due to an error.");
                }
                else
                {
                    Console.WriteLine($"Task {taskId} completed successfully.");
                }
            }));
        }

        try
        {
           
            await Task.WhenAll(tasks);
        }
        catch (AggregateException ae)
        {
            Console.WriteLine("\n Caught exceptions:");
            foreach (var ex in ae.InnerExceptions)
            {
                Console.WriteLine($"   - {ex.Message}");
            }
        }

        Console.WriteLine("\n Summary: All tasks attempted, some may have failed.");
    }
}
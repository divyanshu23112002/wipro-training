using System;

class Program
{
    static Queue<string> taskQueue = new Queue<string>();
    static object locker = new object();
    static bool done = false;
    static void Worker()
    {
        while(true)
        {
            string task = null;
            lock(locker)
            {
                if (taskQueue.Count > 0) task = taskQueue.Dequeue();
                else if (done) break;

            }
            if(task!=null)
            {
                Console.WriteLine($"Processing: {task}");
                Thread.Sleep(500);


            }
            else
            {
                Thread.Sleep(100);
            }
        }
        Console.WriteLine("Worker thread exiting.");
    }
    static void Main()
    {
        Thread worker = new Thread(Worker);
        worker.Start();
        for(int i=1;i<=5;i++)
        {
            lock (locker) taskQueue.Enqueue($"Task {i}");
            Console.WriteLine($"Enqueued: Task {i}");
            Thread.Sleep(200);

        }
        lock(locker)
        {
            done = true;
        }
        worker.Join();
        Console.WriteLine("All task Processed.");
    }
}
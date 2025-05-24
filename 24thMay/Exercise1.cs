using System;

class ThreadControl
{
    static bool pause = false;
    static  bool stop=false;
    static object lockOb=new object();

    static void PrintNumbers()
    {
        for(int i = 1;i<=100;i++)
        {
            lock(lockOb)
            {
                while(pause)
                {
                    Monitor.Wait(lockOb);
                }
                if(stop)
                {
                    Console.WriteLine("Tread Stopping");
                    break;
                }
                Console.WriteLine(i);
                Thread.Sleep(100);
            }
        }
    }
    static void Main()
    {
        Thread thread=new Thread(PrintNumbers);
        thread.Start();
        Console.WriteLine("Thread started. State: "+thread.ThreadState);
        Thread.Sleep(1000);
        Console.WriteLine("Pausing thread...");
        pause = true;
        Console.WriteLine("Thread started. State: " + thread.ThreadState);
        Thread.Sleep(2000);
        Console.WriteLine("Resuming thread...");
        lock(lockOb)
        {
            pause = false;
            Monitor.Pulse(lockOb);
        }
        Thread.Sleep(2000);
        Console.WriteLine("Stopping thread...");
        stop = true;
        lock(lockOb)
        {
            Monitor.Pulse(lockOb);
        }
        thread.Join();
        Console.WriteLine("Thread finished. Final State: " + thread.ThreadState);
    }
}
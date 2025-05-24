using System;
using System.Diagnostics;
using System.Threading.Tasks;
class ExecutionTime
{
    static async Task SimulatedWork(string name,int delay)
    {
        Console.WriteLine($"{name} started");
        await Task.Delay( delay );
        Console.WriteLine($"{name} completed.");
    }
    static async Task Main()
    {

        Console.WriteLine("Sequential Execution:");
        Stopwatch sw=Stopwatch.StartNew();

        await SimulatedWork("Work 1", 1000);
        await SimulatedWork("Work 2", 1000);
        await SimulatedWork("Work 3", 1000);
        sw.Stop();
        Console.WriteLine($"Sequential Time: {sw.ElapsedMilliseconds}ms\n");
        Console.WriteLine("Parallel Execution:");
        sw.Restart();


        Task t1 = SimulatedWork("Work 1", 1000);
        Task t2 = SimulatedWork("Work 2", 1000);
        Task t3 = SimulatedWork("Work 3", 1000);

        await Task.WhenAll(t1 , t2 , t3 );
        sw.Stop();
        Console.WriteLine($"Paralle Time {sw.ElapsedMilliseconds}ms");




    }
}
using System;
class CancellationE
{
    static async Task DoWork(CancellationToken token)
    {
        try
        {
            for(int i=1;i<=10;i++)
            {
                token.ThrowIfCancellationRequested();

                Console.WriteLine($"Working... {i}");  // check for cancellation
                await Task.Delay(500);
            }
            Console.WriteLine("Work Completed Successfully");
        }
        catch(OperationCanceledException)
        {
            Console.WriteLine("Work was Cancelled.");
        }
    }
    static async Task Main()
    {
        using CancellationTokenSource cts=new CancellationTokenSource();

        Task workTask=DoWork(cts.Token);

        await Task.Delay(2000);


        cts.Cancel();


        await workTask;
    }
}
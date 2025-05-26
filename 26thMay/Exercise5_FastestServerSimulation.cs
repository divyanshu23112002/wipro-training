using System;
class Program
{
    static async Task<string>ServerAsync(string name,CancellationToken token)
    {
        var delay=new Random().Next(1000,5000);
        await Task.Delay(delay,token);
        token.ThrowIfCancellationRequested();
        return $"{name} responded in {delay}ms";
    }
    static async Task Main()
    {
        using var cts=new CancellationTokenSource();
        var serverTasks = new[]
        {
            ServerAsync("Server1",cts.Token),
            ServerAsync("Server2",cts.Token),
            ServerAsync("Server3",cts.Token)
        };
        var fast=await Task.WhenAny(serverTasks);
        Console.WriteLine(await fast);
        cts.Cancel();

        try
        {
            await Task.WhenAll(serverTasks);
        }
        catch(OperationCanceledException)
        {
            Console.WriteLine("Slower Server Cancelled");
        }
    }
}
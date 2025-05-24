using System;
using System.Diagnostics;
using System.Diagnostics.Metrics;
class ParallelDown
{
    static async Task DownloadFile(string fileName,int delay)
    {
        Console.WriteLine($"Started downloading {fileName}");
        await Task.Delay( delay );
        Console.WriteLine($"Finished downloading {fileName}");
    }
    static async Task Main()
    {
        var stop=Stopwatch.StartNew();

        Task t1 = DownloadFile("File1.zip", 2000);
        Task t2 = DownloadFile("File2.zip", 3000);
        Task t3 = DownloadFile("File3.pdf", 1000);

        await Task.WhenAll(t1 , t2 , t3 );

        stop.Stop();
        Console.WriteLine($"All downlaods completed in {stop.ElapsedMilliseconds}ms");
    }
        }
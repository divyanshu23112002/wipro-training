using System;
using System.Threading.Tasks;
class Program
{
    // Async method to simulate a file download
    static async Task DownloadFileAsync(string fileName,int delayMs)
    {
        Console.WriteLine($"Starting download: {fileName}");
        await Task .Delay( delayMs ); //Simulate time taken to download
        Console.WriteLine($"Completed download: {fileName} {delayMs}ms");

    }
    static async Task Main()
    {
        Console.WriteLine("Starting all downloads..\n");


        // Start all downloas concurrently
        Task f1 = DownloadFileAsync("file1.pdf", 3000);
        Task f2 = DownloadFileAsync("file2.jpg", 2000);
        Task f3 = DownloadFileAsync("file3.zip", 4000);


        //Wait for all downloads to complete
        await Task.WhenAll(f1 , f2 , f3 );
        Console.WriteLine("\nAll downloads completed.");

    }
}
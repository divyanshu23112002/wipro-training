using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        
        List<string> images = Enumerable.Range(1, 20)
                                        .Select(i => $"Image{i}.jpg")
                                        .ToList();

        int total = images.Count;
        int completed = 0;

        
        await Parallel.ForEachAsync(images, async (image, ct) =>
        {
           
            await Task.Delay(200);

            
            int done = Interlocked.Increment(ref completed);
            int percentage = done * 100 / total;

            Console.WriteLine($"Processed {image} — {percentage}% done");
        });

        Console.WriteLine("\n All image files processed.");
    }
}
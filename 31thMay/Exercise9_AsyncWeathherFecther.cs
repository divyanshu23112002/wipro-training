using System;
using System.Diagnostics;
using System.Threading.Tasks;

class WeatherFetcher
{
    public async Task<string> FetchWeatherAsync(string city)
    {
        Console.WriteLine($"Fetching weather for {city}...");
        await Task.Delay(new Random().Next(2000, 4000)); // Simulate network delay
        return $"{city}: {new Random().Next(20, 35)}°C";
    }
}

class Program
{
    static async Task Main()
    {
        WeatherFetcher fetcher = new WeatherFetcher();
        string[] cities = { "Delhi", "Mumbai", "Chennai" };

        Stopwatch stopwatch = Stopwatch.StartNew();

        Task<string>[] tasks = new Task<string>[cities.Length];

        for (int i = 0; i < cities.Length; i++)
        {
            tasks[i] = fetcher.FetchWeatherAsync(cities[i]);
        }

        string[] results = await Task.WhenAll(tasks);

        stopwatch.Stop();

        Console.WriteLine("\nWeather Report:");
        foreach (string result in results)
        {
            Console.WriteLine(result);
        }

        Console.WriteLine($"\nTotal time taken: {stopwatch.ElapsedMilliseconds / 1000.0:0.00} seconds");
    }
}
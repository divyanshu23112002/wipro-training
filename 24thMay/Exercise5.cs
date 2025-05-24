using System;
class AsyncTemp
{
    static async Task<int>GetTemp(string city)
    {
        Random rnd = new Random();
        await Task.Delay(1000);

        int temp=rnd.Next(-10,45);

        Console.WriteLine($"Temperature for {city} retrived.");
        return temp;
    }
    static async Task Main()
    {
        Console.WriteLine("Fetching temperatures...");
        Task<int> t1 = GetTemp("Delhi");
        Task<int> t2 = GetTemp("Mumbai");
        Task<int> t3 = GetTemp("Kanpur");

        int[] temps=await Task.WhenAll(t1 , t2, t3);

        Console.WriteLine($"Delhi: {temps[0]} degree Celsiue");
        Console.WriteLine($"Mumbai: {temps[1]} degree Celsiue");
        Console.WriteLine($"Kanpur: {temps[2]} degree Celsiue");

    }
}
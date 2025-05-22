using System;
class Program
{
    static void Main()
    {
        string s = "C# is great and C# is fun";
        var words=s.Split(' ',StringSplitOptions.RemoveEmptyEntries);
        var wordFrequency = words.GroupBy(word => word.ToLower()).
            Select(group => new { Word = group.Key, Count = group.Count() });

        Console.WriteLine("Word Frequencies");
        foreach (var item in wordFrequency)
        {
            Console.WriteLine($"{item.Word} : {item.Count}");
        }
    }
}
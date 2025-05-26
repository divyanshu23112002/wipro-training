using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        
        string paragraph = @"C# is a powerful language. C# is used for building web, desktop, and mobile applications. 
                             The C# language is simple, modern, and object-oriented.";

        
        string[] words = paragraph
            .ToLower() 
            .Split(new char[] { ' ', ',', '.', ';', ':', '-', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

        
        Dictionary<string, int> wordFrequency = new Dictionary<string, int>();

        foreach (string word in words)
        {
            if (wordFrequency.ContainsKey(word))
                wordFrequency[word]++;
            else
                wordFrequency[word] = 1;
        }

        
        var topWords = wordFrequency
            .OrderByDescending(pair => pair.Value)
            .Take(5);

       
        Console.WriteLine(" Top 5 Most Frequent Words:");
        foreach (var pair in topWords)
        {
            Console.WriteLine($"{pair.Key} - {pair.Value} times");
        }
    }
}
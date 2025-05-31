using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a paragraph:");
        string input = Console.ReadLine();

        string[] words = input
            .Split(new char[] { ' ', '.', ',', '?', '!', ';', ':', '-', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries);

        var wordFrequency = words
            .GroupBy(w => w.ToLower())
            .ToDictionary(g => g.Key, g => g.Count());

        int vowelCount = 0;
        int consonantCount = 0;

        foreach (char c in input.ToLower())
        {
            if (char.IsLetter(c))
            {
                if ("aeiou".Contains(c))
                    vowelCount++;
                else
                    consonantCount++;
            }
        }

        string longestWord = words.OrderByDescending(w => w.Length).FirstOrDefault();
        string shortestWord = words.OrderBy(w => w.Length).FirstOrDefault();

        Console.WriteLine("\nWord Frequency:");
        foreach (var kvp in wordFrequency.OrderByDescending(kvp => kvp.Value))
        {
            Console.WriteLine($"{kvp.Key} : {kvp.Value}");
        }

        Console.WriteLine($"\nVowel count: {vowelCount}");
        Console.WriteLine($"Consonant count: {consonantCount}");
        Console.WriteLine($"Longest word: {longestWord}");
        Console.WriteLine($"Shortest word: {shortestWord}");
    }
}
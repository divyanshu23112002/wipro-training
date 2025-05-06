using System;
class Program
{
    static void Main()
    {
        string input = "Learning C# is fun";
        int count = CountWords(input);
        Console.WriteLine($"{count} Words");

    }
    static int CountWords(string sentence)
    {
        if (string.IsNullOrWhiteSpace(sentence)) return 0;
        int count = 0;
        bool words = false;
        foreach (char c in sentence)
        {
            if (char.IsWhiteSpace(c))
            {
                words = false;
            }
            else if (!words)
            {
                words = true;
                count++;
            }
        }
        return count;
    }
}
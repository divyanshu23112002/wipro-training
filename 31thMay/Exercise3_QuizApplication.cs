using System;
using System.Collections.Generic;

public class Question
{
    public string Text { get; set; }
    public List<string> Options { get; set; }
    public int CorrectOption { get; set; }

    public Question(string text, List<string> options, int correctOption)
    {
        Text = text;
        Options = options;
        CorrectOption = correctOption;
    }

    public bool Ask()
    {
        Console.WriteLine(Text);
        for (int i = 0; i < Options.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {Options[i]}");
        }

        Console.Write("Your answer (1-4): ");
        int userAnswer;
        bool isValid = int.TryParse(Console.ReadLine(), out userAnswer);
        if (!isValid || userAnswer < 1 || userAnswer > 4)
        {
            Console.WriteLine("Invalid input.");
            return false;
        }

        return userAnswer == CorrectOption;
    }
}

class Program
{
    static void Main()
    {
        List<Question> questions = new List<Question>
        {
            new Question("What is the capital of France?", new List<string> { "Paris", "Rome", "London", "Berlin" }, 1),
            new Question("Which planet is known as the Red Planet?", new List<string> { "Earth", "Mars", "Venus", "Jupiter" }, 2),
            new Question("What is the largest ocean on Earth?", new List<string> { "Atlantic", "Indian", "Pacific", "Arctic" }, 3),
            new Question("Who wrote 'Hamlet'?", new List<string> { "Shakespeare", "Tolkien", "Hemingway", "Dickens" }, 1),
            new Question("Which element has the chemical symbol 'O'?", new List<string> { "Oxygen", "Gold", "Iron", "Osmium" }, 1)
        };

        ShuffleQuestions(questions);

        int score = 0;
        int total = 3;

        for (int i = 0; i < total; i++)
        {
            Console.WriteLine($"\nQuestion {i + 1}:");
            bool isCorrect = questions[i].Ask();
            if (isCorrect)
            {
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine("Incorrect.");
            }
        }

        Console.WriteLine($"\nYou scored {score} out of {total}.");
    }

    static void ShuffleQuestions(List<Question> list)
    {
        Random rng = new Random();
        int n = list.Count;
        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            Question value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
    }
}
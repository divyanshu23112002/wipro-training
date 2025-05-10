//ChatBot

using System;
public class ChatBot
{
    public void Respond(string message)
    {
        Console.WriteLine("ChatBot Hello! you Said \""+message+"\"");
    }
    public void Respond(string question,bool isFormal)
    {
        if(isFormal)
        {
            Console.WriteLine("ChatBot: That's an excellent Question . Let me think....");
        }
        else
        {
            Console.Write("ChatBot: Hmm.. Good one!");
        }
    }
    public void Respond(int num)
    {
        Console.WriteLine("ChatBot: You gave me the number " + num + ". Let me do Some Math... It's double is " + (num * 2));
    }
}
public class Program
{
    public static void Main()
    {
        ChatBot bot = new ChatBot();
        bot.Respond("Hi There! ");
        bot.Respond("What is the weather today ? ", true);
        bot.Respond("Any Plans",false);
        bot.Respond(48);
    }
}
using System;
class Program
{
    public static string findLongest(string s)
    {
        char[] ch = s.ToCharArray();
        string word = "";
        string currWord = "";
        for (int i = 0; i < ch.Length; i++) {
            if (ch[i]!=' ')
            {
                currWord += ch[i];
            }
            else
            {
                if (currWord.Length > word.Length)
                    word = currWord;
                currWord = "";
            }

            }
        if (currWord.Length > word.Length)word = currWord;
        return word;

       
    }
    static void Main()
    {
        string s = "Learnin C# is really interesting";
        string res=findLongest(s);
        Console.WriteLine("Longest Word: "+res);
    }
}
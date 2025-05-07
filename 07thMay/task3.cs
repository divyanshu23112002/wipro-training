using System;
class Program
{
    public static void printDuplicate (string s)
    {
        string[] words = new string[100];
        int count = 0;
        string currWord = "";
        for (int i = 0; i < s.Length; i++) {
            if (s[i] != ' ')
            {
                currWord += Char.ToLower(s[i]);
            }
            else
            {
                if (currWord.Length > 0)
                {
                    words[count++] = currWord;
                    currWord = "";
                }
            }
        }
        if(currWord.Length > 0) words[count++] = currWord;
        bool[] vis = new bool[count];
        Console.Write("Duplicate Words : ");
        for (int i = 0; i < count; i++)
        {
            if (vis[i]) continue;
            int count1 = 1;
            for (int j = i + 1; j < count; j++)
            {
                if (!vis[j] && words[i] == words[j])
                {
                    count1++;
                    vis[j] = true;
                }
            }
            if (count1 > 1)
            {
                Console.Write(words[i] + ", ");
            }
        }
        Console.WriteLine();
        

       
    }
    static void Main()
    {
        string s = "This is a test and this test is fun";
        printDuplicate(s);
    }
}
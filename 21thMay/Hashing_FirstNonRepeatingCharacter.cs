using System;
using System.Collections.Generic;
class Program
{
    static char FirstNonRepeatingChar(string input)
    {
        Dictionary<char,int>freq = new Dictionary<char,int>();
        foreach (char c in input)
        {
            if(freq.ContainsKey(c)) freq[c]++;
            else freq[c] = 1;   

        }
        foreach(char c in input)
        {
            if (freq[c]==1)return c;
        }
        return '\0';
    }
    static void Main()
    {
        string input = "swiss";
        char res=FirstNonRepeatingChar(input);
        if(res!='\0')Console.WriteLine("First non-repeating Character : "+res);
        else Console.WriteLine("No non-repeating Character Found");
    }
}
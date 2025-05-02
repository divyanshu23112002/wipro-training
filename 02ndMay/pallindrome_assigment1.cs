// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld

{
    static bool ispallindrome(string word){
        string rev="";
        for(int i=word.Length-1;i>=0;i--){
            rev+=word[i];
        }
        return word==rev;
    }
    static void Main()
    {
        Console.WriteLine ("Enter a Word :");
        string input=Console.ReadLine();
        if(ispallindrome(input))Console.WriteLine("Pallindrome");
        else Console.WriteLine("Not Pallindrome");
    }
}
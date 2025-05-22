using System;
class Program
{
    static void Main()
    {
        List<string> names = new List<string>
        {
            "Ram","Olivia","Shyam","Mohan","Rohan","Sohan","Karan","Arjun","Sita","Geeta","Rita"
        };
        var vowels = new[] { 'A', 'E', 'I', 'O', 'U' };
        var filterdNames = names.Where(name => vowels.Contains(char.ToUpper(name[0]))).ToList();
        Console.WriteLine("Name Starting with Vowel: ");
        foreach(var n in filterdNames) Console.WriteLine(n);
    }
}
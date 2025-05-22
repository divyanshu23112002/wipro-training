using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
       Dictionary<string,string>phoneBook= new Dictionary<string,string>();
        phoneBook.Add("Ram", "123-456-7890");
        phoneBook.Add("Shyam", "345-678-9012");
        phoneBook.Add("Mohan", "234-678-1234");
        phoneBook.Add("Sohan", "789-012-3456");
        phoneBook.Add("Rohan", "890-123-6789");
        Console.WriteLine("Phone Book Contacts: ");
        foreach(var contact in phoneBook)Console.WriteLine($"{contact.Key} : {contact.Value}");
        Console.WriteLine("\nEnter name to Search: ");
        string search=Console.ReadLine();
        if (phoneBook.ContainsKey(search)) Console.WriteLine($"Phone number for {search} : {phoneBook[search]}");
        else Console.WriteLine("Contact Not Found");
    }
}
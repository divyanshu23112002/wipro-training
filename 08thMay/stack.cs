using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //creatin a stack of string
        Stack<string>books = new Stack<string>();

        //pushin elements oto te stack
        books.Push("C# Proramming");
        books.Push("Data Structure");
        books.Push("Macine Learning");

        Console.WriteLine("Books in te stack : ");
        foreach(var book in books) Console.WriteLine(book);

        //popping te elements
        Console.WriteLine("\nPopped : "+books.Pop());

        //Peeking at the top of elements
        Console.WriteLine("Next on the Stack : "+books.Peek());



    }
}

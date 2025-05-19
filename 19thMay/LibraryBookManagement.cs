using System;
using System.Collections.Generic;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public Book(string title, string author)
    {
        Title = title; Author = author;
    }
    public void Print()
    {
        Console.WriteLine($"Title : {Title}, Author: {Author}");
    }
}
class Program
{
    static void Main()
    {
        Queue<Book> borrowedBook=new Queue<Book>();
        borrowedBook.Enqueue(new Book("The Hobbit", "J.R.R Tolkien"));
        borrowedBook.Enqueue(new Book("Pride and Prejudice", "Jane Austen"));
        borrowedBook.Enqueue(new Book("To Kill a Mockinbird", "Harper Lee"));
        borrowedBook.Enqueue(new Book("The Great Gatsby", "F. Scott Fitzerald"));
        borrowedBook.Enqueue(new Book("1984", "George Orwell"));

        Console.WriteLine("Next book to be returned");

        borrowedBook.Peek().Print();

        Console.WriteLine("\nReturning the book...");
        borrowedBook.Dequeue();

        Console.WriteLine("\nRemaining borrowed books.");

        foreach(var book in borrowedBook)book.Print();

        Stack<Book>newBook=new Stack<Book>();
        newBook.Push(new Book("Clean Code", "Robert C. Martin"));
        newBook.Push(new Book("The Pragmatic Programmer", "Andrew Hunt"));
        newBook.Push(new Book("The guide", "R K Narayan"));

        Console.WriteLine("\nLast book purchased:");
        newBook.Peek().Print();

        Console.WriteLine("\nProcessing newly purchased books:");
        foreach(var book in newBook) book.Print();  

    }
}
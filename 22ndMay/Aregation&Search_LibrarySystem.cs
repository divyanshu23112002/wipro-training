using System;
public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public bool IsAvailable { get; set; }

    public Book(int id, string title, string author, bool isAvailable)
    {
        Id = id;
        Title = title;
        Author = author;
        IsAvailable = isAvailable;
    }
}

public class Library
{
    private List<Book> books = new List<Book>();

    public void AddBook(Book book)
    {
        books.Add(book);
    }

    public List<Book> SearchByAuthor(string author)
    {
        return books.Where(b => b.Author.Equals(author, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    public List<Book> SearchByTitle(string title)
    {
        return books.Where(b => b.Title.IndexOf(title, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
    }

    public void DisplayBooks(List<Book> bookList)
    {
        if (bookList.Count == 0)
        {
            Console.WriteLine("No books found.");
            return;
        }

        foreach (var book in bookList)
        {
            Console.WriteLine($"Id: {book.Id}, Title: {book.Title}, Author: {book.Author}, Available: {book.IsAvailable}");
        }
    }
}

class Program
{
    public static void Main()
    {
        Library library = new Library();

        
        library.AddBook(new Book(1, "The Great Gatsby", "F. Scott Fitzgerald", true));
        library.AddBook(new Book(2, "To Kill a Mockingbird", "Harper Lee", false));
        library.AddBook(new Book(3, "1984", "George Orwell", true));
        library.AddBook(new Book(4, "Animal Farm", "George Orwell", true));

        
        Console.WriteLine("Books by George Orwell:");
        var booksByOrwell = library.SearchByAuthor("George Orwell");
        library.DisplayBooks(booksByOrwell);

        
        Console.WriteLine("\nSearch for title containing 'Great':");
        var booksWithTitle = library.SearchByTitle("Great");
        library.DisplayBooks(booksWithTitle);
    }
}
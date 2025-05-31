using System;
using System.Collections.Generic;
using System.Linq;

public class Book
{
    public int BookId { get; set; }
    public string Title { get; set; }
    public bool IsBorrowed { get; set; }
    public string BorrowedBy { get; set; }
    public DateTime? DueDate { get; set; }

    public Book(int id, string title)
    {
        BookId = id;
        Title = title;
        IsBorrowed = false;
        BorrowedBy = null;
        DueDate = null;
    }
}

public class Student
{
    public string Name { get; set; }

    public Student(string name)
    {
        Name = name;
    }
}

class Program
{
    static List<Book> books = new List<Book>();
    static List<Student> students = new List<Student>();

    static void Main()
    {
        books.Add(new Book(1, "The Alchemist"));
        books.Add(new Book(2, "1984"));
        books.Add(new Book(3, "To Kill a Mockingbird"));

        students.Add(new Student("Alice"));
        students.Add(new Student("Bob"));

        while (true)
        {
            Console.WriteLine("\nLibrary Menu:");
            Console.WriteLine("1. Show All Books");
            Console.WriteLine("2. Add New Book");
            Console.WriteLine("3. Delete Book");
            Console.WriteLine("4. Borrow Book");
            Console.WriteLine("5. Show Borrowed Books");
            Console.WriteLine("6. Exit");
            Console.Write("Enter choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ShowAllBooks();
                    break;
                case "2":
                    AddBook();
                    break;
                case "3":
                    DeleteBook();
                    break;
                case "4":
                    BorrowBook();
                    break;
                case "5":
                    ShowBorrowedBooks();
                    break;
                case "6":
                    return;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }

    static void ShowAllBooks()
    {
        Console.WriteLine("\nAll Books:");
        foreach (var book in books)
        {
            string status = book.IsBorrowed ? $"(Borrowed by {book.BorrowedBy}, Due: {book.DueDate?.ToShortDateString()})" : "(Available)";
            Console.WriteLine($"{book.BookId}. {book.Title} {status}");
        }
    }

    static void AddBook()
    {
        Console.Write("Enter new book title: ");
        string title = Console.ReadLine();
        int id = books.Any() ? books.Max(b => b.BookId) + 1 : 1;
        books.Add(new Book(id, title));
        Console.WriteLine("Book added successfully.");
    }

    static void DeleteBook()
    {
        Console.Write("Enter Book ID to delete: ");
        int id = int.Parse(Console.ReadLine());
        Book book = books.FirstOrDefault(b => b.BookId == id);
        if (book != null)
        {
            books.Remove(book);
            Console.WriteLine("Book deleted.");
        }
        else
        {
            Console.WriteLine("Book not found.");
        }
    }

    static void BorrowBook()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Student student = students.FirstOrDefault(s => s.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        if (student == null)
        {
            Console.WriteLine("Student not registered.");
            return;
        }

        Console.Write("Enter Book ID to borrow: ");
        int id = int.Parse(Console.ReadLine());
        Book book = books.FirstOrDefault(b => b.BookId == id);

        if (book == null)
        {
            Console.WriteLine("Book not found.");
        }
        else if (book.IsBorrowed)
        {
            Console.WriteLine("Book already borrowed.");
        }
        else
        {
            book.IsBorrowed = true;
            book.BorrowedBy = name;
            book.DueDate = DateTime.Now.AddDays(7);
            Console.WriteLine($"Book borrowed successfully. Due date: {book.DueDate?.ToShortDateString()}");
        }
    }

    static void ShowBorrowedBooks()
    {
        var borrowed = books.Where(b => b.IsBorrowed);
        Console.WriteLine("\nBorrowed Books:");
        foreach (var book in borrowed)
        {
            Console.WriteLine($"{book.BookId}. {book.Title} - Borrowed by {book.BorrowedBy} (Due: {book.DueDate?.ToShortDateString()})");
        }
    }
}
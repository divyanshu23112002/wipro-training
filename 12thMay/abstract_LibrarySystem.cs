using System;

public abstract class Book
{
    public abstract void Read();
    public void GetInfo()
    {
        Console.WriteLine("This is a book");
    }
}
public class FictionBook:Book
{
    public override void Read()
    {
        Console.WriteLine("Reading a Fiction Book");
    }
}
public class ScienceBook:Book
{
    public override void Read()
    {
        Console.WriteLine("Reading a Science Book");
    }
}
class Program
{
    static void Main()
    {
        Book fiction=new FictionBook();
        Book science=new ScienceBook();

        fiction.GetInfo();
        fiction.Read();

        science.GetInfo();
        science.Read();
    }
}
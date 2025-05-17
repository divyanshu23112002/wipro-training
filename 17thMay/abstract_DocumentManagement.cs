using System;
public abstract class Document
{
    public void ShowDocumentType(string type)
    {
        Console.WriteLine($"Document Type: {type}");
    }
    public abstract void PrintContent();
}
public class WordDocumnet:Document
{
    public override void PrintContent()
    {
       Console.WriteLine("Printing word Documnet");
    }
}
public class PDFDocumnet:Document
{
    public override void PrintContent()
    {
       Console.WriteLine("Printing PDF Document");
    }
}
class Program
{
    static void Main()
    {
        Document doc;
        doc=new WordDocumnet();
        doc.ShowDocumentType("Word");
        doc.PrintContent();

        Console.WriteLine();

        doc=new PDFDocumnet();
        doc.ShowDocumentType("PDF");
        doc.PrintContent();
    }
}
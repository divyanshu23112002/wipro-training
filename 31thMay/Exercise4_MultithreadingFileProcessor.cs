using System;
using System.IO;
using System.Threading;

class FileProcessor
{
    private string filePath;
    private int lineCount;
    private static object lockObj = new object();
    private static int totalLines = 0;

    public FileProcessor(string path)
    {
        filePath = path;
    }

    public void ReadFile()
    {
        int localCount = 0;
        if (File.Exists(filePath))
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                while (sr.ReadLine() != null)
                {
                    localCount++;
                }
            }
        }

        lock (lockObj)
        {
            totalLines += localCount;
            Console.WriteLine($"File: {Path.GetFileName(filePath)} - Lines: {localCount}");
        }
    }

    public static int GetTotalLines()
    {
        return totalLines;
    }
}

class Program
{
    static void Main()
    {
        string file1 = "file1.txt";
        string file2 = "file2.txt";
        string file3 = "file3.txt";

        CreateSampleFile(file1, 100);
        CreateSampleFile(file2, 150);
        CreateSampleFile(file3, 200);

        FileProcessor processor1 = new FileProcessor(file1);
        FileProcessor processor2 = new FileProcessor(file2);
        FileProcessor processor3 = new FileProcessor(file3);

        Thread t1 = new Thread(processor1.ReadFile);
        Thread t2 = new Thread(processor2.ReadFile);
        Thread t3 = new Thread(processor3.ReadFile);

        t1.Start();
        t2.Start();
        t3.Start();

        t1.Join();
        t2.Join();
        t3.Join();

        Console.WriteLine($"\nTotal lines across all file: {FileProcessor.GetTotalLines()}");
    }

    static void CreateSampleFile(string filename, int lines)
    {
        if (!File.Exists(filename))
        {
            using (StreamWriter sw = new StreamWriter(filename))
            {
                for (int i = 1; i <= lines; i++)
                {
                    sw.WriteLine($"This is line {i}");
                }
            }
        }
    }
}
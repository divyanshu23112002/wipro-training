using System;

public abstract class CompressionStrategy
{
    public abstract void Compress(string inputPath, string outputPath);
}


public class ZipCompression : CompressionStrategy
{
    public override void Compress(string inputPath, string outputPath)
    {
        Console.WriteLine($"[ZIP] Compressing from {inputPath} to {outputPath} using ZIP compression.");
    }
}


public class RarCompression : CompressionStrategy
{
    public override void Compress(string inputPath, string outputPath)
    {
        Console.WriteLine($"[RAR] Compressing from {inputPath} to {outputPath} using RAR compression.");
    }
}

public class Compressor
{
    private CompressionStrategy _strategy;

    public Compressor(CompressionStrategy strategy)
    {
        _strategy = strategy;
    }

    public void SetStrategy(CompressionStrategy strategy)
    {
        _strategy = strategy;
    }

    public void Compress(string input, string output)
    {
        _strategy.Compress(input, output);
    }
}


class Program
{
    static void Main()
    {
       
        Compressor compressor = new Compressor(new ZipCompression());
        compressor.Compress("FolderA", "ArchiveA.zip");

    
        compressor.SetStrategy(new RarCompression());
        compressor.Compress("FolderB", "ArchiveB.rar");
    }
}
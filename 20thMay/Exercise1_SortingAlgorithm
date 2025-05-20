using System;
using System.Diagnostics;

class Program
{
    // Bubble Sort
    public static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
            for (int j = 0; j < n - i - 1; j++)
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
    }

    // Selection Sort
    public static void SelectionSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int minIdx = i;
            for (int j = i + 1; j < n; j++)
                if (arr[j] < arr[minIdx])
                    minIdx = j;

            int temp = arr[minIdx];
            arr[minIdx] = arr[i];
            arr[i] = temp;
        }
    }

    // Insertion Sort
    public static void InsertionSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 1; i < n; ++i)
        {
            int key = arr[i];
            int j = i - 1;

            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j--;
            }
            arr[j + 1] = key;
        }
    }


    public static void PrintArray(int[] arr)
    {
        Console.WriteLine(string.Join(", ", arr));
    }

   
    public static int[] GenerateRandomArray(int size, int min = 1, int max = 100)
    {
        Random rnd = new Random();
        int[] arr = new int[size];
        for (int i = 0; i < size; i++)
            arr[i] = rnd.Next(min, max + 1);
        return arr;
    }

    static void Main(string[] args)
    {
        int[] original = GenerateRandomArray(20);
        Console.WriteLine("Original Array:");
        PrintArray(original);

        // Bubble Sort
        int[] bubble = (int[])original.Clone();
        Stopwatch sw = Stopwatch.StartNew();
        BubbleSort(bubble);
        sw.Stop();
        Console.WriteLine("\nBubble Sort:");
        PrintArray(bubble);
        Console.WriteLine("Time Taken: " + sw.ElapsedTicks + " ticks");

        // Selection Sort
        int[] selection = (int[])original.Clone();
        sw.Restart();
        SelectionSort(selection);
        sw.Stop();
        Console.WriteLine("\nSelection Sort:");
        PrintArray(selection);
        Console.WriteLine("Time Taken: " + sw.ElapsedTicks + " ticks");

        // Insertion Sort
        int[] insertion = (int[])original.Clone();
        sw.Restart();
        InsertionSort(insertion);
        sw.Stop();
        Console.WriteLine("\nInsertion Sort:");
        PrintArray(insertion);
        Console.WriteLine("Time Taken: " + sw.ElapsedTicks + " ticks");
    }
}
using System;

class Program
{
    static (int index, int comparisons) LinearSearch(int[] arr, int key)
    {
        int comparisons = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            comparisons++;
            if (arr[i] == key)
                return (i, comparisons);
        }
        return (-1, comparisons);
    }

    static (int index, int comparisons) BinarySearch(int[] arr, int key)
    {
        int low = 0, high = arr.Length - 1, comparisons = 0;

        while (low <= high)
        {
            comparisons++;
            int mid = (low + high) / 2;
            if (arr[mid] == key)
                return (mid, comparisons);
            else if (arr[mid] < key)
                low = mid + 1;
            else
                high = mid - 1;
        }

        return (-1, comparisons);
    }

    static int[] GenerateSortedArray(int size, int max)
    {
        Random rnd = new Random();
        int[] arr = new int[size];
        arr[0] = rnd.Next(1, 5);
        for (int i = 1; i < size; i++)
            arr[i] = arr[i - 1] + rnd.Next(1, 5);
        return arr;
    }

    static void RunTest(string label, int[] arr, int key)
    {
        Console.WriteLine($"\n{label}");
        Console.WriteLine($"Searching for {key}");

        var (index1, comp1) = LinearSearch(arr, key);
        Console.WriteLine($"Linear Search: Index = {index1}, Comparisons = {comp1}");

        var (index2, comp2) = BinarySearch(arr, key);
        Console.WriteLine($"Binary Search: Index = {index2}, Comparisons = {comp2}");
    }

    static void Main()
    {
        // Small list
        int[] small = GenerateSortedArray(10, 50);
        int key1 = small[new Random().Next(small.Length)];
        RunTest("Small List (10 elements)", small, key1);

        // Large list
        int[] large = GenerateSortedArray(1000, 2000);
        int key2 = large[new Random().Next(large.Length)];
        RunTest("Large List (1000 elements)", large, key2);
    }
}
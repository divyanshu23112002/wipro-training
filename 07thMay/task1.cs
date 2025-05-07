using System;
class Program
{
    public static void printFrequencies(int[] arr)
    {
        bool[] vis = new bool[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            if (vis[i] == true) continue;
            int count = 1;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] == arr[j])
                {
                    count++;
                    vis[j] = true;
                }
            }
            Console.WriteLine(arr[i] + " apperars " + count + " times " + (count > 1 ? "" : ""));
        }
    }
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 2, 4 };
        printFrequencies(arr);
    }
}
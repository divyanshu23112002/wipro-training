using System;

class HelloWorld
{
    static void Main()
    {
        int[] arr = { 10, 20, 30, 40, 50, 50 };
        bool[] visited = new bool[arr.Length];

        for (int i = 0; i < arr.Length; i++)
        {
            if (visited[i])
                continue;

            int count = 1;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] == arr[j])
                {
                    count++;
                    visited[j] = true;
                }
            }

            Console.WriteLine($"{arr[i]} occurs {count} time{(count > 1 ? "s" : "")}");
        }
    }
}

using System;
class Program
{
    static void Main()
    {
        int n = 4;
        printTriangle(n);

    }
    static void printTriangle(int n)
    {
        for (int i = 1; i <=n; i++)
        {
            printStar(i);
            Console.WriteLine();
        }
        static void printStar(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("* ");

            }

        }
    }
}
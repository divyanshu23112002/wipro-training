using System;

class Program
{
    static void SolveNQueens(int n)
    {
        int[] board = new int[n];
        PlaceQueens(board, 0, n);
    }

    static void PlaceQueens(int[] board, int row, int n)
    {
        if (row == n)
        {
            PrintBoard(board, n);
            return;
        }

        for (int col = 0; col < n; col++)
        {
            if (IsSafe(board, row, col))
            {
                board[row] = col;
                PlaceQueens(board, row + 1, n);
            }
        }
    }

    static bool IsSafe(int[] board, int row, int col)
    {
        for (int i = 0; i < row; i++)
        {
            int otherCol = board[i];
            if (otherCol == col || Math.Abs(otherCol - col) == Math.Abs(i - row))
                return false;
        }
        return true;
    }

    static void PrintBoard(int[] board, int n)
    {
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                if (board[row] == col)
                    Console.Write("Q ");
                else
                    Console.Write("_ ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        int n = 4;
        SolveNQueens(n);
    }
}
using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char[][] board = new char[n][];

        // Fill the board
        for (int i = 0; i < n; i++)
        {
            board[i] = Console.ReadLine().ToCharArray();
        }

        int knightsToRemove = CalculateKnightsToRemove(board, n);
        Console.WriteLine(knightsToRemove);
    }

    static int CalculateKnightsToRemove(char[][] board, int n)
    {
        int knightsToRemove = 0;

        // Iterate over each cell containing a knight
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (board[i][j] == 'K')
                {
                    // Check all possible knight moves
                    if (IsAttackedByKnight(board, n, i - 2, j - 1) ||
                        IsAttackedByKnight(board, n, i - 2, j + 1) ||
                        IsAttackedByKnight(board, n, i - 1, j - 2) ||
                        IsAttackedByKnight(board, n, i - 1, j + 2) ||
                        IsAttackedByKnight(board, n, i + 1, j - 2) ||
                        IsAttackedByKnight(board, n, i + 1, j + 2) ||
                        IsAttackedByKnight(board, n, i + 2, j - 1) ||
                        IsAttackedByKnight(board, n, i + 2, j + 1))
                    {
                        knightsToRemove++;
                    }
                }
            }
        }

        return knightsToRemove / 2; // Each pair of threatening knights is counted twice
    }

    static bool IsAttackedByKnight(char[][] board, int n, int row, int col)
    {
        return row >= 0 && row < n && col >= 0 && col < n && board[row][col] == 'K';
    }
}

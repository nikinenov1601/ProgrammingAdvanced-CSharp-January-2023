using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<List<int>> matrix = new List<List<int>>();

        // Populate the matrix
        for (int i = 0; i < n; i++)
        {
            List<int> row = new List<int>();
            string[] rowValues = Console.ReadLine().Split();
            foreach (string value in rowValues)
            {
                row.Add(int.Parse(value));
            }
            matrix.Add(row);
        }

        // Analyze and manipulate the matrix
        for (int i = 0; i < n - 1; i++)
        {
            if (matrix[i].Count == matrix[i + 1].Count)
            {
                for (int j = 0; j < matrix[i].Count; j++)
                {
                    matrix[i][j] *= 2;
                    matrix[i + 1][j] *= 2;
                }
            }
            else
            {
                for (int j = 0; j < matrix[i].Count; j++)
                {
                    matrix[i][j] /= 2;
                }
                for (int j = 0; j < matrix[i + 1].Count; j++)
                {
                    matrix[i + 1][j] /= 2;
                }
            }
        }

        // Process commands
        while (true)
        {
            string command = Console.ReadLine();
            if (command == "End")
                break;

            string[] tokens = command.Split();
            string action = tokens[0];
            int row = int.Parse(tokens[1]);
            int col = int.Parse(tokens[2]);
            int value = int.Parse(tokens[3]);

            if (IsValidCoordinate(row, col, matrix))
            {
                if (action == "Add")
                {
                    matrix[row][col] += value;
                }
                else if (action == "Subtract")
                {
                    matrix[row][col] -= value;
                }
            }
        }

        // Print the final state of the matrix
        foreach (List<int> row in matrix)
        {
            Console.WriteLine(string.Join(" ", row));
        }
    }

    static bool IsValidCoordinate(int row, int col, List<List<int>> matrix)
    {
        return row >= 0 && row < matrix.Count && col >= 0 && col < matrix[row].Count;
    }
}

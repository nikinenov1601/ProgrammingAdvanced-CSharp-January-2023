using System;

class Program
{
    static void Main()
    {
        // Read the dimensions of the matrix
        string[] dimensions = Console.ReadLine().Split();
        int rows = int.Parse(dimensions[0]);
        int cols = int.Parse(dimensions[1]);

        // Create the matrix
        string[,] matrix = new string[rows, cols];

        // Read the matrix values
        for (int i = 0; i < rows; i++)
        {
            string[] rowValues = Console.ReadLine().Split();
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = rowValues[j];
            }
        }

        // Process commands
        while (true)
        {
            string command = Console.ReadLine();
            if (command == "END")
                break;

            string[] tokens = command.Split();
            if (tokens.Length != 5 || tokens[0] != "swap")
            {
                Console.WriteLine("Invalid input!");
                continue;
            }

            if (!int.TryParse(tokens[1], out int row1) || !int.TryParse(tokens[2], out int col1) ||
                !int.TryParse(tokens[3], out int row2) || !int.TryParse(tokens[4], out int col2) ||
                !IsValidCoordinate(row1, col1, rows, cols) || !IsValidCoordinate(row2, col2, rows, cols))
            {
                Console.WriteLine("Invalid input!");
                continue;
            }

            // Swap values
            string temp = matrix[row1, col1];
            matrix[row1, col1] = matrix[row2, col2];
            matrix[row2, col2] = temp;

            // Print the matrix after swap
            PrintMatrix(matrix);
        }
    }

    static bool IsValidCoordinate(int row, int col, int numRows, int numCols)
    {
        return row >= 0 && row < numRows && col >= 0 && col < numCols;
    }

    static void PrintMatrix(string[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

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
        int[,] matrix = new int[rows, cols];

        // Read the matrix values
        for (int i = 0; i < rows; i++)
        {
            string[] rowValues = Console.ReadLine().Split();
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = int.Parse(rowValues[j]);
            }
        }

        // Find the square with the maximal sum
        int maxSum = int.MinValue;
        int maxSumRow = -1;
        int maxSumCol = -1;

        for (int i = 0; i <= rows - 3; i++)
        {
            for (int j = 0; j <= cols - 3; j++)
            {
                int sum = CalculateSum(matrix, i, j);
                if (sum > maxSum)
                {
                    maxSum = sum;
                    maxSumRow = i;
                    maxSumCol = j;
                }
            }
        }

        // Output the elements of the 3x3 square with maximal sum
        Console.WriteLine("Sum = " + maxSum);
        for (int i = maxSumRow; i < maxSumRow + 3; i++)
        {
            for (int j = maxSumCol; j < maxSumCol + 3; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static int CalculateSum(int[,] matrix, int startRow, int startCol)
    {
        int sum = 0;
        for (int i = startRow; i < startRow + 3; i++)
        {
            for (int j = startCol; j < startCol + 3; j++)
            {
                sum += matrix[i, j];
            }
        }
        return sum;
    }
}

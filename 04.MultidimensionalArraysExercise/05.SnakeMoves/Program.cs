// Read dimensions of the matrix and the snake string
string[] dimensions = Console.ReadLine().Split();
int n = int.Parse(dimensions[0]);
int m = int.Parse(dimensions[1]);
string snake = Console.ReadLine();

// Create the matrix
char[,] matrix = new char[n, m];

// Initialize variables for snake index and direction
int snakeIndex = 0;

// Fill the matrix with the snake's path
for (int row = 0; row < n; row++)
{
    // Check if row is even or odd to determine direction
    if (row % 2 == 0)
    {
        // Fill from left to right
        for (int col = 0; col < m; col++)
        {
            if (snakeIndex == snake.Length)
                snakeIndex = 0; // Reset index if end of snake string is reached
            matrix[row, col] = snake[snakeIndex++];
        }
    }
    else
    {
        // Fill from right to left
        for (int col = m - 1; col >= 0; col--)
        {
            if (snakeIndex == snake.Length)
                snakeIndex = 0; // Reset index if end of snake string is reached
            matrix[row, col] = snake[snakeIndex++];
        }
    }
}

// Print the matrix
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(matrix[i, j]);
    }
    Console.WriteLine();
}
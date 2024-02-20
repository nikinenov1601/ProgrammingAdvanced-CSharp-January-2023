// Read the dimensions of the matrix
string[] dimensions = Console.ReadLine().Split();
int rows = int.Parse(dimensions[0]);
int cols = int.Parse(dimensions[1]);

// Create the matrix
char[,] matrix = new char[rows, cols];

// Read the matrix values
for (int i = 0; i < rows; i++)
{
    string[] rowValues = Console.ReadLine().Split();
    for (int j = 0; j < cols; j++)
    {
        matrix[i, j] = char.Parse(rowValues[j]);
    }
}

// Count the 2x2 squares of equal characters
int count = 0;
for (int i = 0; i < rows - 1; i++)
{
    for (int j = 0; j < cols - 1; j++)
    {
        if (matrix[i, j] == matrix[i, j + 1] &&
            matrix[i, j] == matrix[i + 1, j] &&
            matrix[i, j] == matrix[i + 1, j + 1])
        {
            count++;
        }
    }
}

// Output the result
Console.WriteLine(count);
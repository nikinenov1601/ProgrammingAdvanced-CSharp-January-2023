// Read the size of the square matrix
int n = int.Parse(Console.ReadLine());

// Create the square matrix
int[,] matrix = new int[n, n];

// Read the matrix values
for (int i = 0; i < n; i++)
{
    string[] rowValues = Console.ReadLine().Split();
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = int.Parse(rowValues[j]);
    }
}

// Calculate the sums of the diagonals
int primarySum = 0;
int secondarySum = 0;
for (int i = 0; i < n; i++)
{
    primarySum += matrix[i, i];
    secondarySum += matrix[i, n - 1 - i];
}

// Calculate the absolute difference
int difference = Math.Abs(primarySum - secondarySum);

// Output the result
Console.WriteLine(difference);
int n = int.Parse(Console.ReadLine());

int[][] pascalsTriangle = new int[n][];

for (int i = 0; i < n; i++)
{
    pascalsTriangle[i] = new int[i + 1];
    pascalsTriangle[i][0] = 1; // First element of each row is always 1

    for (int j = 1; j < i; j++)
    {
        pascalsTriangle[i][j] = pascalsTriangle[i - 1][j - 1] + pascalsTriangle[i - 1][j];
    }

    pascalsTriangle[i][i] = 1; // Last element of each row is always 1
}

// Print Pascal's triangle
for (int i = 0; i < n; i++)
{
    // Add leading spaces for formatting
    Console.Write(new string(' ', (n - i - 1) * 2));

    for (int j = 0; j <= i; j++)
    {
        Console.Write(pascalsTriangle[i][j] + " ");
    }

    Console.WriteLine();
}
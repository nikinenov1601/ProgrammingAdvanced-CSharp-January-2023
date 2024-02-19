int n = int.Parse(Console.ReadLine());

char[,] matrix = new char[n, n];

for (int i = 0; i < n; i++)
{
    string row = Console.ReadLine();
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = row[j];
    }
}

char symbol = char.Parse(Console.ReadLine());

bool found = false;
int symbolRow = -1;
int symbolCol = -1;

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (matrix[i, j] == symbol)
        {
            symbolRow = i;
            symbolCol = j;
            found = true;
            break;
        }
    }
    if (found)
        break;
}

if (found)
{
    Console.WriteLine($"({symbolRow}, {symbolCol})");
}
else
{
    Console.WriteLine($"{symbol} does not occur in the matrix");
}
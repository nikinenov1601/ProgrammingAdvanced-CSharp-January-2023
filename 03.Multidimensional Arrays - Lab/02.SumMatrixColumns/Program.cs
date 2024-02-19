
int[] sizes = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

int[,] matrix = new int[sizes[0], sizes[1]];

for (int i = 0; i < sizes[0]; i++)
{
    int[] rowItems = Console.ReadLine().Split().Select(int.Parse).ToArray();

    for (int j = 0; j < sizes[1]; j++)
    {
        matrix[i, j] = rowItems[j];
    }
}

for (int j = 0; j < sizes[1]; j++)
{
    int sumCol = 0;

    for (int i = 0; i < sizes[0]; i++)
    {
        sumCol += matrix[i, j];
    }
    Console.WriteLine(sumCol);
}
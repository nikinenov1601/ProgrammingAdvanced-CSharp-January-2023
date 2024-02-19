
int number = int.Parse(Console.ReadLine()); // Един номер за row & col

int[,] matrix = new int[number, number]; // Задаваме размера на матрицата

int sum = 0;

for (int row = 0; row < number; row++)
{
    int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();

    for (int col = 0; col < number; col++)
    {
        matrix[row, col] = elements[col]; // Попълваме матрицата
    }
}

for (int row = 0; row < number; row++)
{
    for (int col = 0; col < number; col++)
    {
        sum += matrix[row, col];
        row++;
    }
}
Console.WriteLine(sum);
int rows = int.Parse(Console.ReadLine());

int[,] matrix = new int[rows, rows];

// Fill the matrix with initial values
for (int i = 0; i < rows; i++)
{
    string[] rowValues = Console.ReadLine().Split();
    for (int j = 0; j < rows; j++)
    {
        matrix[i, j] = int.Parse(rowValues[j]);
    }
}

// Process commands
while (true)
{
    string command = Console.ReadLine();
    if (command == "END")
    {
        break;
    }

    string[] tokens = command.Split();
    string operation = tokens[0];
    int row = int.Parse(tokens[1]);
    int col = int.Parse(tokens[2]);
    int value = int.Parse(tokens[3]);

    if (row < 0 || row >= rows || col < 0 || col >= rows)
    {
        Console.WriteLine("Invalid coordinates");
        continue;
    }

    if (operation == "Add")
    {
        matrix[row, col] += value;
    }
    else if (operation == "Subtract")
    {
        matrix[row, col] -= value;
    }
}

// Print the matrix
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < rows; j++)
    {
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
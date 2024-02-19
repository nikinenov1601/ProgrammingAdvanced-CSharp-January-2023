
int[] sizes = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

int row = sizes[0]; // sizes[0] = 3
int col = sizes[1]; // sizes[1] = 6

int[,] matrix = new int[row, col]; // int[,] matrix = new int[3, 6]

int sum = 0;

for (int i = 0; i < row; i++)
{
    int[] colElements = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
    // i [0] = 7, 1, 3, 3, 2, 1
    // i [1] = 1, 3, 9, 8, 5, 6
    // i [2] = 4, 6, 7, 9, 1, 0
    //        [0][1][2][3][4][5]

    for (int j = 0; j < col; j++)
    {
        sum += colElements[j];
    }
}

Console.WriteLine(sizes[0]);
Console.WriteLine(sizes[1]);
Console.WriteLine(sum);
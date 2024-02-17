int n = int.Parse(Console.ReadLine());
int[][] petrolPumps = new int[n][];

for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split();
    int petrol = int.Parse(input[0]);
    int distance = int.Parse(input[1]);
    petrolPumps[i] = new int[] { petrol, distance };
}

int start = 0;
int remainingPetrol = 0;

for (int i = 0; i < n; i++)
{
    remainingPetrol += petrolPumps[i][0] - petrolPumps[i][1];

    if (remainingPetrol < 0)
    {
        start = i + 1;
        remainingPetrol = 0;
    }
}

Console.WriteLine(start);
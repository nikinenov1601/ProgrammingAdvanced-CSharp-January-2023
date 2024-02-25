

Dictionary<int, int> numbersCount = new();

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    int number = int.Parse(Console.ReadLine());

    if (!numbersCount.ContainsKey(number))
    {
        numbersCount.Add(number, 0);
    }

    numbersCount[number]++;
}

int result = numbersCount.Single(nc => nc.Value % 2 == 0).Key;

Console.WriteLine(result);

int n = int.Parse(Console.ReadLine());

SortedSet<string> uniqueElements = new SortedSet<string>();

for (int i = 0; i < n; i++)
{
    string[] compounds = Console.ReadLine().Split(' ');

    foreach (string compound in compounds)
    {
        uniqueElements.Add(compound);
    }
}

Console.WriteLine(string.Join(" ", uniqueElements));
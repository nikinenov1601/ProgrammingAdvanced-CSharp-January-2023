﻿int n = int.Parse(Console.ReadLine());

HashSet<string> names = new HashSet<string>();

for (int i = 0; i < n; i++)
{
    string name = Console.ReadLine();

    if (names.Contains(name))
    {
        names.Remove(name);
    }

    names.Add(name);
}

foreach (string name in names)
{
    Console.WriteLine(name);
}

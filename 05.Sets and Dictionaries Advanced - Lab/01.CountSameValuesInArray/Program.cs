
List<double> numbers = Console.ReadLine().
    Split(" ", StringSplitOptions.RemoveEmptyEntries).
    Select(double.Parse).
    ToList();

// Правим си лист за да определим стойностите, които ще използваме

Dictionary<double, int> numbersCount = new Dictionary<double, int>();

// Въвеждаме един празен речник в който ще попълваме ключ и стойност

foreach (double number in numbers) // за всяко число от листа
{
    if (!numbersCount.ContainsKey(number)) // Ако няма такъв ключ в речника
    {
        numbersCount.Add(number, 1); // Се въвежда със стойност 1
    }
    else // Ако има такъв ключ в речника
    {
        numbersCount[number]++; // Увеличаваме стойноста му с 1
    }
}

foreach (var count in numbersCount) // За всеки един ключ в речника
{
    Console.WriteLine($"{count.Key} - {count.Value} times");
}

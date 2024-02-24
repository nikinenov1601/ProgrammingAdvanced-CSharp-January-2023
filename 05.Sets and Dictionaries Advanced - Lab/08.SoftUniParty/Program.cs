using Microsoft.VisualBasic;

string input = Console.ReadLine();
HashSet<string> reservationNumbers = new HashSet<string>();

while (input != "PARTY")
{
    reservationNumbers.Add(input);

    input = Console.ReadLine();
}

while (input != "END")
{
    if (reservationNumbers.Contains(input))
    {
        reservationNumbers.Remove(input);
    }

    input = Console.ReadLine();
}

Console.WriteLine(reservationNumbers.Count);

var sortedStrings = reservationNumbers.OrderBy(s => !char.IsDigit(s.FirstOrDefault()));

foreach (string reservationNumber in sortedStrings)
{
    Console.WriteLine(reservationNumber);
}
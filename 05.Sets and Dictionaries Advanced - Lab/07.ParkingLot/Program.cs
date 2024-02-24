
string input = Console.ReadLine();

HashSet<string> carNumbers = new HashSet<string>();

while (input != "END")
{
    string[] splittedInput = input.Split(", ");

    string command = splittedInput[0];
    string number = splittedInput[1];

    if (command == "IN")
    {
        carNumbers.Add(number);
    }

    else if (command == "OUT")
    {
        carNumbers.Remove(number);
    }


    input = Console.ReadLine();

}

if (carNumbers.Count == 0)
{
    Console.WriteLine("Parking Lot is Empty");
}

else
{
    foreach (string car in carNumbers)
    {
        Console.WriteLine(car);
    }
}
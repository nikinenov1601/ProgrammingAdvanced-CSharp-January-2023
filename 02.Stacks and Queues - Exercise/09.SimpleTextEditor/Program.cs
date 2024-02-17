using System.Text;

int n = int.Parse(Console.ReadLine());
Stack<string> history = new Stack<string>();
StringBuilder text = new StringBuilder();

for (int i = 0; i < n; i++)
{
    string[] operation = Console.ReadLine().Split();
    string command = operation[0];

    if (command == "1")
    {
        string argument = operation[1];
        history.Push(text.ToString());
        text.Append(argument);
    }
    else if (command == "2")
    {
        int count = int.Parse(operation[1]);
        history.Push(text.ToString());
        text.Length -= count;
    }
    else if (command == "3")
    {
        int index = int.Parse(operation[1]) - 1;
        Console.WriteLine(text[index]);
    }
    else if (command == "4")
    {
        text = new StringBuilder(history.Pop());
    }
}
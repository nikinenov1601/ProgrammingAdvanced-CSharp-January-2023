
string[] commands = Console.ReadLine().Split(' ');

int N = int.Parse(commands[0]);
int S = int.Parse(commands[1]);
int X = int.Parse(commands[2]);

string[] numbers = Console.ReadLine().Split(' ');

Queue<int> queue = new Queue<int>();

for (int i = 0; i < N; i++)
{
    queue.Enqueue(int.Parse(numbers[i]));
}

for (int i = 0; i < S; i++)
{
    if (queue.Count > 0)
    {
        queue.Dequeue();
    }
}

if (queue.Count == 0)
{
    Console.WriteLine(0);
}

else if (queue.Contains(X))
{
    Console.WriteLine("true");
}

else
{
    int minNumber = int.MaxValue;

    foreach (var number in queue)
    {
        if (minNumber > number)
        {
            minNumber = number;
        }
    }
    Console.WriteLine(minNumber);
}
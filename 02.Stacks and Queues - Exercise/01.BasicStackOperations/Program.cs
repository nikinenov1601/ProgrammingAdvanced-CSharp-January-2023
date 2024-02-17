
string[] input = Console.ReadLine().Split();

int N = int.Parse(input[0]);
int S = int.Parse(input[1]);
int X = int.Parse(input[2]);

string[] arrayOfNumbers = Console.ReadLine().Split();

Stack<int> stack = new Stack<int>();

for (int i = 0; i < N; i++)
{
    stack.Push(int.Parse(arrayOfNumbers[i]));
}

for (int i = 0; i < S; i++)
{
    if (stack.Count > 0)
    {
        stack.Pop();
    }
}

if (stack.Count == 0)
{
    Console.WriteLine(0);
}

else if (stack.Contains(X))
{
    Console.WriteLine("true");
}

else
{
    int minNumber = int.MaxValue;

    foreach (var number in stack)
    {
        if (minNumber > number)
        {
            minNumber = number;
        }
    }
    Console.WriteLine(minNumber);
}
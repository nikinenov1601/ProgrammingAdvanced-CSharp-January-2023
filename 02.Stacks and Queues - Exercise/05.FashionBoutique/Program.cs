
int[] clothes = Console.ReadLine()
    .Split()
    .Reverse()
    .Select(int.Parse)
    .ToArray();

Stack<int> stack = new Stack<int>(clothes);
int capacity = int.Parse(Console.ReadLine());
int secondValueForCapacity = capacity;

int racksCounter = 1;

while (stack.Count > 0)
{
    int cuurentClothing = stack.Peek();

    if (capacity >= cuurentClothing)
    {
        stack.Pop();
        capacity -= cuurentClothing;
    }
    else
    {
        racksCounter++;
        capacity = secondValueForCapacity;
    }
}

Console.WriteLine(racksCounter);

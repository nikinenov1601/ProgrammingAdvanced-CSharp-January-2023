
int food = int.Parse(Console.ReadLine());

int[] orders = Console.ReadLine()
    .Split()
    .Reverse()
    .Select(int.Parse)
    .ToArray();

Stack<int> stack = new Stack<int>(orders);

Console.WriteLine(stack.Max());

while (stack.Count > 0)
{
    int firstNumber = stack.Peek();

    if (food >= firstNumber)
    {
        stack.Pop();
        food -= firstNumber;
    }

    else
    {
        break;
    }
}

if (stack.Count == 0)
{
    Console.WriteLine("Orders complete");
}

else
{
    Console.Write($"Orders left: " + string.Join(" ", stack));
}
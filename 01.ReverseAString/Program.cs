var input = Console.ReadLine();
var stack = new Stack<char>();

foreach (var letter in input)
{
    stack.Push(letter);
}

while (stack.Count > 0)
{
    Console.Write(stack.Pop());
}
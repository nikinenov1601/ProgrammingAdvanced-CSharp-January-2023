string sequence = Console.ReadLine();
Stack<char> stack = new Stack<char>();

foreach (char c in sequence)
{
    if (c == '(' || c == '{' || c == '[')
    {
        stack.Push(c);
    }
    else
    {
        if (stack.Count == 0)
        {
            Console.WriteLine("NO");
            return;
        }

        char top = stack.Pop();

        if ((c == ')' && top != '(') ||
            (c == '}' && top != '{') ||
            (c == ']' && top != '['))
        {
            Console.WriteLine("NO");
            return;
        }
    }
}

if (stack.Count == 0)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}
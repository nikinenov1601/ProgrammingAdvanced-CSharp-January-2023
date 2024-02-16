using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int capacity = int.Parse(Console.ReadLine());

        Queue<string> queue = new Queue<string>();
        int passedCars = 0;

        while (true)
        {
            string command = Console.ReadLine();

            if (command == "end")
            {
                Console.WriteLine($"{passedCars} cars passed the crossroads.");
                break;
            }

            if (command == "green")
            {
                int carsToPass = Math.Min(queue.Count, capacity);
                for (int i = 0; i < carsToPass; i++)
                {
                    string car = queue.Dequeue();
                    Console.WriteLine($"{car} passed!");
                    passedCars++;
                }
            }
            else
            {
                queue.Enqueue(command);
            }
        }
    }
}

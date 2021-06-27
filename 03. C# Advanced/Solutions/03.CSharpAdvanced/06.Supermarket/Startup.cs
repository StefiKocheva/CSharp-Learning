namespace _06.Supermarket
{
    using System;
    using System.Collections.Generic;

    public static class Startup
    {
        public static void Main()
        {
            var people = new Queue<string>();

            string command = Console.ReadLine();

            while (command != "End")
            {
                people.Enqueue(command);

                if (command == "Paid")
                {
                    int count = people.Count - 1;

                    for (int i = 0; i < count; i++)
                    {
                        Console.WriteLine(people.Dequeue());
                    }

                    people.Dequeue();
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"{people.Count} people remaining.");
        }
    }
}

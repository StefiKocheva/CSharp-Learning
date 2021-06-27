namespace _08.TrafficJam
{
    using System;
    using System.Collections.Generic;

    public static class Startup
    {
        public static void Main()
        {
            Queue<string> cars = new Queue<string>();

            int n = int.Parse(Console.ReadLine());

            var count = 0;

            string command = Console.ReadLine();

            while (command != "end")
            {
                if (command == "green")
                {
                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine($"{cars.Dequeue()} passed!");

                        count++;
                    }
                }
                else
                {
                    cars.Enqueue(command);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"{count} cars passed the crossroads.");
        }
    }
}

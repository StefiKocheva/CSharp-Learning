namespace _07.HotPotato
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class Startup
    {
        public static void Main()
        {
            Queue<string> circleOfKids = new Queue<string>(Console
                .ReadLine()
                .Split()
                .ToArray());

            int gone = int.Parse(Console.ReadLine());

            while (circleOfKids.Count > 1)
            {
                for (int i = 0; i < gone - 1; i++)
                {
                    circleOfKids.Enqueue(circleOfKids.Dequeue());
                }

                Console.WriteLine($"Removed {circleOfKids.Dequeue()}");
            }

            Console.WriteLine($"Last is {circleOfKids.Peek()}");
        }
    }
}

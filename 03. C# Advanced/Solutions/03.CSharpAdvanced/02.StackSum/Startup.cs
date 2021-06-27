namespace _02.StackSum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class Startup
    {
        public static void Main()
        {
            Stack<int> nums = new Stack<int>();

            foreach (var num in Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray())
            {
                nums.Push(num);
            }

            string command = Console.ReadLine().ToLower();

            while (command != "end")
            {
                var commandInfo = command.Split().ToArray();

                switch (commandInfo[0])
                {
                    case "add":
                        nums.Push(int.Parse(commandInfo[1]));
                        nums.Push(int.Parse(commandInfo[2]));
                        break;
                    case "remove":
                        for (int i = 0; i < int.Parse(commandInfo[1]); i++)
                        {
                            if (nums.Count > int.Parse(commandInfo[1]))
                            {
                                nums.Pop();
                            }
                            else
                            {
                                return;
                            }
                        }
                        break;
                }

                command = Console.ReadLine().ToLower();
            }

            Console.WriteLine($"Sum: {nums.Sum()}");
        }
    }
}

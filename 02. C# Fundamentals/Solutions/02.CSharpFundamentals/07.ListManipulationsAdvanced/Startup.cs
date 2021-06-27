namespace _07.ListManipulationsAdvanced
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class Startup
    {
        public static void Main()
        {
            List<int> numbers = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();

            bool isListChanged = false;

            while (command != "end")
            {
                string[] currentCommand = command.Split().ToArray();

                switch (currentCommand[0])
                {
                    case "Add":
                        numbers.Add(int.Parse(currentCommand[1]));
                        isListChanged = true;
                        break;
                    case "Remove":
                        numbers.Remove(int.Parse(currentCommand[1]));
                        isListChanged = true;
                        break;
                    case "RemoveAt":
                        numbers.RemoveAt(int.Parse(currentCommand[1]));
                        isListChanged = true;
                        break;
                    case "Insert":
                        numbers.Insert(int.Parse(currentCommand[2]), int.Parse(currentCommand[1]));
                        isListChanged = true;
                        break;
                    case "Contains":
                        Console.WriteLine(numbers.Contains(int.Parse(currentCommand[1])) ? "Yes" : "No such number");
                        break;
                    case "PrintEven":
                        numbers.Where(number => number % 2 == 0).ToList().ForEach(number => Console.Write(number + " "));
                        Console.WriteLine();
                        break;
                    case "PrintOdd":
                        numbers.Where(number => number % 2 != 0).ToList().ForEach(number => Console.Write(number + " "));
                        Console.WriteLine();
                        break;
                    case "GetSum":
                        Console.WriteLine(numbers.Sum());
                        break;
                    case "Filter":
                        switch (currentCommand[1])
                        {
                            case ">":
                                numbers.Where(number => number > int.Parse(currentCommand[2])).ToList().ForEach(number => Console.Write(number + " "));
                                Console.WriteLine();
                                break;
                            case ">=":
                                numbers.Where(number => number >= int.Parse(currentCommand[2])).ToList().ForEach(number => Console.Write(number + " "));
                                Console.WriteLine();
                                break;
                            case "<":
                                numbers.Where(number => number < int.Parse(currentCommand[2])).ToList().ForEach(number => Console.Write(number + " "));
                                Console.WriteLine();
                                break;
                            case "<=":
                                numbers.Where(number => number <= int.Parse(currentCommand[2])).ToList().ForEach(number => Console.Write(number + " "));
                                Console.WriteLine();
                                break;
                        }
                        break;
                }

                command = Console.ReadLine();
            }

            if (isListChanged)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}

namespace _06.ListManipulationBasics
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
            // { 4, 19, 2, 53, 6, 43 }
            string command = Console.ReadLine(); // "Add 3"

            while (command != "end") // "Add 3" != "end"
            {
                string[] currentCommand = command.Split().ToArray(); // { "Add", "3"}

                switch (currentCommand[0]) // "Add"
                {
                    case "Add":
                        numbers.Add(int.Parse(currentCommand[1])); // numbers.Add(3)
                        break;
                    case "Remove":
                        numbers.Remove(int.Parse(currentCommand[1])); 
                        break;
                    case "RemoveAt":
                        numbers.RemoveAt(int.Parse(currentCommand[1]));
                        break;
                    case "Insert":
                        numbers.Insert(int.Parse(currentCommand[2]), int.Parse(currentCommand[1]));
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}

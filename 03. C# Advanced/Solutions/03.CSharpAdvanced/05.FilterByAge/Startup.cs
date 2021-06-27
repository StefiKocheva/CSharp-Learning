namespace _05.FilterByAge
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class Startup
    {
        public static void Main()
        {
            int count = int.Parse(Console.ReadLine());

            var people = new Dictionary<string, int>();

            for (int i = 0; i < count; i++)
            {
                var person = Console.ReadLine().Split(", ");

                people.Add(person[0], int.Parse(person[1]));
            }

            var conditionInput = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());

            Func<Dictionary<string, int>, Dictionary<string, int>> output = p => conditionInput switch
            {
                "younger" => p.Where(p => p.Value < age).ToDictionary(k => k.Key, v => v.Value),
                "older" => p.Where(p => p.Value >= age).ToDictionary(k => k.Key, v => v.Value),
                _ => null,
            };

            var format = Console.ReadLine();

            Print(output(people), format);
        }

        private static void Print(Dictionary<string, int> people, string format)
        {
            foreach (var (key, value) in people)
            {
                switch (format)
                {
                    case "name":
                        Console.WriteLine(key);
                        break;
                    case "age":
                        Console.WriteLine(value);
                        break;
                    case "name age":
                        Console.WriteLine($"{key} - {value}");
                        break;
                }
            }
        }
    }
}

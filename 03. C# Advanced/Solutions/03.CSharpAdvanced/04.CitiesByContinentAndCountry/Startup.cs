namespace _04.CitiesByContinentAndCountry
{
    using System;
    using System.Collections.Generic;

    public static class Startup
    {
        public static void Main()
        {
            var count = int.Parse(Console.ReadLine());

            var cities = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < count; i++)
            {
                string[] cityInfo = Console.ReadLine().Split();

                if (!cities.ContainsKey(cityInfo[0]))
                {
                    cities.Add(cityInfo[0], new Dictionary<string, List<string>>());
                }

                if (!cities[cityInfo[0]].ContainsKey(cityInfo[1]))
                {
                    cities[cityInfo[0]].Add(cityInfo[1], new List<string>());
                }

                cities[cityInfo[0]][cityInfo[1]].Add(cityInfo[2]);
            }

            foreach (var (key, value) in cities)
            {
                Console.WriteLine($"{key}:");

                foreach (var city in value)
                {
                    Console.WriteLine($"  {city.Key} -> {string.Join(", ", city.Value)}");
                }
            }
        }
    }
}

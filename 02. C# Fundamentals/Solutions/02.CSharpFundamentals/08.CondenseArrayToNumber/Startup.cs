namespace _08.CondenseArrayToNumber
{
    using System;
    using System.Linq;

    public static class Startup
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            if (numbers.Length == 1)
            {
                Console.WriteLine(numbers[0]);
            }
            else
            {
                int count = numbers.Length;
                while (count > 1)
                {
                    int[] condensed = new int[count - 1];

                    for (int i = 0; i < condensed.Length; i++)
                    {
                        condensed[i] = numbers[i] + numbers[i + 1];
                    }

                    numbers = new int[count - 1];

                    for (int i = 0; i < numbers.Length; i++)
                    {
                        numbers[i] = condensed[i];
                    }

                    count--;
                }
                Console.WriteLine(numbers[0]);
            }
        }
    }
}

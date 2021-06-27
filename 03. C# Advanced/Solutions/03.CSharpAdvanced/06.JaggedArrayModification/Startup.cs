namespace _06.JaggedArrayModification
{
    using System;
    using System.Linq;

    public static class Startup
    {
        public static void Main()
        {
            int rows = int.Parse(Console.ReadLine());

            int cols = 0;

            int[][] nums = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                nums[i] = Console
                    .ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                if (nums[i].Length > cols)
                {
                    cols = nums[i].Length;
                }
            }

            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] commandInfo = command.Split();

                int row = int.Parse(commandInfo[1]);
                int col = int.Parse(commandInfo[2]);
                int value = int.Parse(commandInfo[3]);

                if (row > rows - 1 || col > cols - 1 || row < 0 || col < 0)
                {
                    Console.WriteLine("Invalid coordinates");

                    command = Console.ReadLine();

                    continue;
                }

                switch (commandInfo[0])
                {
                    case "Add":
                        nums[row][col] += value;
                        break;
                    case "Subtract":
                        nums[row][col] -= value;
                        break;
                }

                command = Console.ReadLine();
            }

            foreach (var arr in nums)
            {
                Console.WriteLine(string.Join(" ", arr));
            }
        }
    }
}
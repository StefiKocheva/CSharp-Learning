namespace _01.OddLines
{
    using System;
    using System.IO;
    using System.Text;
    using System.Threading.Tasks;

    public static class Startup
    {
        public static async Task Main()
        {
            using var reader = new StreamReader("Input.txt");

            int count = 0;

            using var writer = new StreamWriter("Output.txt"); // Uses Open Or Create

            var line = await reader.ReadLineAsync();

            while (line != null)
            {
                if (count % 2 != 0)
                {
                    await writer.WriteLineAsync(line);
                }

                count++;

                line = await reader.ReadLineAsync();
            }
        }
    }
}

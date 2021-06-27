namespace _02.LineNumbers
{
    using System;
    using System.IO;
    using System.Threading.Tasks;

    public static class Startup
    {
        public static async Task Main()
        {
            using var reader = new StreamReader("Input.txt");

            var line = await reader.ReadLineAsync();

            int count = 1;

            using var writer = new StreamWriter("Output.txt");

            while (line != null)
            {
                await writer.WriteLineAsync($"{count}. {line}");

                line = await reader.ReadLineAsync();
                count++;
            }
        }
    }
}

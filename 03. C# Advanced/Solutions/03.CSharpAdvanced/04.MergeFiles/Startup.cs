namespace _04.MergeFiles
{
    using System.Collections.Generic;
    using System.IO;

    public static class Startup
    {
        public static void Main()
        {
            var fileOne = File.ReadAllLines("FileOne.txt");
            var fileTwo = File.ReadAllLines("FileTwo.txt");

            var result = fileOne.Length >= fileTwo.Length
                ? MergingValues(fileOne, fileTwo)
                : MergingValues(fileTwo, fileOne);

            File.WriteAllLines("Output.txt", result);
        }

        private static List<string> MergingValues(string[] bigger, string[] smaller)
        {
            List<string> result = new List<string>();

            for (int i = 0; i < smaller.Length; i++)
            {
                result.Add(bigger[i]);
                result.Add(smaller[i]);
            }

            for (int i = smaller.Length; i < bigger.Length; i++)
            {
                result.Add(bigger[i]);
            }

            return result;
        }
    }
}

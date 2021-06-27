namespace _05.SliceAFile
{
    using System;
    using System.IO;

    public static class Startup
    {
        public static void Main()
        {
            var file = File.ReadAllText("sliceMe.txt");

            int partLength = (int)Math.Ceiling((double)file.Length / 4);

            for (int i = 1; i < 4; i++)
            {
                var text = file.Substring(0, partLength);

                File.WriteAllText($"Part-{i}.txt", text);

                file = file.Remove(0, partLength);
            }

            File.WriteAllText($"Part-4.txt", file);
        }
    }
}

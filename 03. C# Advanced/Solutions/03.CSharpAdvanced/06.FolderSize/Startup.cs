namespace _06.FolderSize
{
    using System;
    using System.IO;

    public static class Startup
    {
        public static void Main()
        {
            var files = Directory.GetFiles("TestFolder");

            double size = 0;

            foreach (var file in files)
            {
                FileInfo fileInfo = new FileInfo(file);

                size += fileInfo.Length;
            }

            size = size / 1024 / 1024;

            File.WriteAllText("Output.txt", size.ToString());
        }
    }
}

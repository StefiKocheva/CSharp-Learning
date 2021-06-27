namespace DirectoryClass
{
    using System;
    using System.IO;

    public static class Startup
    {
        public static void Main()
        {
            // File.Create("test.txt"); - Creates a new file.

            Console.WriteLine(Directory.GetCurrentDirectory()); // Gets current directory's absolute path.
            
            Console.WriteLine(string.Join(
                Environment.NewLine, 
                Directory.GetFiles(Directory.GetCurrentDirectory()))); // Returns all files in current directory.
            
            Console.WriteLine(string.Join(
                Environment.NewLine,
                Directory.GetDirectories(Directory.GetCurrentDirectory()))); // Returns all directories in current directory.

            // File.Delete("test.txt"); - Deletes a file.

            var files = Directory.GetFiles(Directory.GetCurrentDirectory());

            var directories = Directory.GetDirectories(Directory.GetCurrentDirectory());

            for (int i = 0; i < files.Length; i++)
            {
                var currentFile = files[i].Split(@"\");
                files[i] = currentFile[currentFile.Length - 1];
            }

            for (int i = 0; i < directories.Length; i++)
            {
                var currentDirectory = directories[i].Split(@"\");
                directories[i] = currentDirectory[currentDirectory.Length - 1];
            }

            Console.WriteLine("Files:");
            Console.WriteLine(string.Join(Environment.NewLine, files));

            Console.WriteLine("Directories:");
            Console.WriteLine(string.Join(Environment.NewLine, directories));

            //Directory.CreateDirectory("TestFolder"); - Create directory.

            //Directory.Delete("TestFolder"); - Delete directory.
        }
    }
}

using System;
using System.IO.Compression;

namespace ZipAndExctract
{   
    class Program
    {
        static void Main(string[] args)
        {
            string startPath = @"C:\Users\stefa\OneDrive\Работен плот\Learning\Input";
            string zipPath = @"copeMe.png";
            string extractPath = @"C:\Users\stefa\OneDrive\Работен плот\Learning\Output";

            ZipFile.CreateFromDirectory(startPath, zipPath);

            ZipFile.ExtractToDirectory(zipPath, extractPath);
        }
    }
}

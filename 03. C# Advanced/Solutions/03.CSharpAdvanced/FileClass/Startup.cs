namespace FileClass
{
    using System;
    using System.IO;

    public static class Startup
    {
        public static void Main()
        {
            string[] names = File.ReadAllLines("Input.txt"); // Returns all lines into an array.

            string input = File.ReadAllText("Input.txt"); // Return the text from the document in a string.

            File.WriteAllText("Output.txt", input); // Write the text into a new file.

            File.WriteAllLines("Output.txt", names); // Write the array into a new file, new line separated.

            File.AppendAllText("Output.txt", "Hi!"); // Append text to the end of the text.


        }
    }
}

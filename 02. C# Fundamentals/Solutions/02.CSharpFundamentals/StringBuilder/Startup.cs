namespace StringBuilder
{
    using System;
    using System.Text;

    public static class Startup
    {
        public static void Main()
        {
            StringBuilder sb = new StringBuilder();

            string name = Console.ReadLine();
            // sb = "";
            sb.Append("Hi, "); // Add the given text to the stringBuilder at the end of the text.
            // sb = "Hi, "
            sb.AppendLine(name + "!"); // First concatenation, then append.
            sb.AppendLine("How old are you?"); // First append, then goes to a new line.

            Console.WriteLine(sb);
        }
    }
}

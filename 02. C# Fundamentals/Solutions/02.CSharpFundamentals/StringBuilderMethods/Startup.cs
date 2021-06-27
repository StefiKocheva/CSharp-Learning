namespace StringBuilderMethods
{
    using System;
    using System.Text;

    public static class Startup
    {
        public static void Main()
        {
            string name = Console.ReadLine();

            Console.WriteLine(Greeting(name));
        }

        private static string Greeting(string name)
        {
            var sb = new StringBuilder();

            sb.Append("Hi, ");

            sb.AppendLine(name + "!");

            sb.AppendLine("How old are you?");

            return sb.ToString().Trim(); // StringBuilder to string
            // .Trim() - Removes the white spaces around the text.
        }
    }
}

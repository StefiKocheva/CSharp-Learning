namespace _01.ReverseStrings
{
    using System;
    using System.Linq;

    public static class Startup
    {
        public static void Main()
        {
            string command = Console.ReadLine();

            while (command != "End")
            {
                // command = "hello";
                // .Reverse() -> IEnumerable<char> { 'o', 'l', 'l', 'e', 'h'}
                // .ToArray() -> char[] { 'o', 'l', 'l', 'e', 'h'}
                // string.Join() -> "olleh"
                // reversedString = "olleh";
                string reversedString = string.Join("", command.Reverse().ToArray());

                Console.WriteLine(command + " = " + reversedString);

                command = Console.ReadLine();
            }
        }
    }
}
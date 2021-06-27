namespace WhileLoop
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            string command = Console.ReadLine();

            while (command != "End") // Iterates the loop unknown times while the command's value is End.
            {
                command = Console.ReadLine(); // Set a new value to the variable command.
            }
        }
    }
}

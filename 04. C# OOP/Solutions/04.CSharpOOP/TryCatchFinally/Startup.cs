namespace TryCatchFinally
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            // We use try-catch construction when we aren't sure for that it's in the right format.
            try
            {
                int.Parse(input); // We have doubt about this line
            }
            // In next lines we list all possible kinda exceptions and how to handle them.
            catch (ArgumentException)
            {
                Console.WriteLine("The argument isn't in the right format.");
            }
            catch (FormatException e) // There is a name of the exception
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e) // Exception should be the last of all catches.
            {
                Console.WriteLine(e.Message);
            }
            finally // No matter it has thrown an error or not, it would execute the following code in finally scope.
            {
                Console.WriteLine("It has ended.");
            }

            // No matter what has happened in the try-catch block the program continues its work till the end.
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine($"I'm {age}-year-old person.");
        }
    }
}

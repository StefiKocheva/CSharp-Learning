namespace VoidMethods
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            string firstName = "Stefani";

            string lastName = "Kocheva";

            int age = 15;

            //Invoke the method
            WhoAmI(firstName, lastName, age); // Give arguments for the parameters on the same position in the brackets of the parameters.

            Walk();
        }

        // Method with parameters
        private static void WhoAmI(string firstName, string lastName, int age) // Describe the parameters with their types.
        {
            Console.WriteLine($"I am {firstName} {lastName} and I'm {age} years old.");
        }

        // Method without parameters
        private static void Walk()
        {
            Console.WriteLine("Walking...");
        }
    }
}

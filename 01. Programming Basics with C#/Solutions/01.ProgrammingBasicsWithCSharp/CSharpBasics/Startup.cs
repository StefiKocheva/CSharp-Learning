namespace CSharpBasics
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            string name = "Stefani"; // Text

            int age = int.Parse(Console.ReadLine()); // Integer read by the console.

            double averageGrade = 4.56; // Number with floating point

            Console.WriteLine(name); // Print on the console.

            Console.WriteLine(name + " " + age); // Concatenation

            Console.WriteLine($"{name} {age}"); // Interpolation
        }
    }
}

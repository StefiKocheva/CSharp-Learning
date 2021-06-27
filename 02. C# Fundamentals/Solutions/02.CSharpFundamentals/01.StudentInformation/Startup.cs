namespace _01.StudentInformation
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            string name = Console.ReadLine();

            int age = int.Parse(Console.ReadLine());

            double grade = double.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}, Age: {age}, Grade: {grade:f2}");
        }
    }
}

namespace _02.Passed
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            double grade = double.Parse(Console.ReadLine());

            if(grade >= 3.00)
            {
                Console.WriteLine("Passed!");
            }
        }
    }
}

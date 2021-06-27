namespace _01.ExcellentGrade
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            double grade = double.Parse(Console.ReadLine());

            if (grade >= 5.50)
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}

namespace _10.LowerOrUpper
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            char letter = char.Parse(Console.ReadLine());

            if (char.IsUpper(letter))
            {
                Console.WriteLine("upper-case");
            }
            else
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}

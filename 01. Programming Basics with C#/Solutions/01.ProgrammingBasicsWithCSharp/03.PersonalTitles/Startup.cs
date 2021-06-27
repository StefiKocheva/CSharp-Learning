namespace _03.PersonalTitles
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            var age = int.Parse(Console.ReadLine());
            var sex = Console.ReadLine();

            if (age >= 16)
            {
                switch (sex)
                {
                    case "m":
                        Console.WriteLine("Mr.");
                        break;
                    case "f":
                        Console.WriteLine("Ms.");
                        break;
                }
            }
            else
            {
                switch (sex)
                {
                    case "m":
                        Console.WriteLine("Master");
                        break;
                    case "f":
                        Console.WriteLine("Miss");
                        break;
                }
            }
        }
    }
}

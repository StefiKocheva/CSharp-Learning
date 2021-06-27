namespace _05.CharacterSequence
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            string text = Console.ReadLine();

            for (int i = 0; i < text.Length; i++)
            {
                Console.WriteLine(text[i]);
            }
        }
    }
}

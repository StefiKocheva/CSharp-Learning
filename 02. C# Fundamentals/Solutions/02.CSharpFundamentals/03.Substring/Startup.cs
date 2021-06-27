namespace _03.Substring
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            string key = Console.ReadLine().ToLower();
            string text = Console.ReadLine().ToLower();

            while (text.Contains(key))
            {
                int index = text.IndexOf(key);

                text.Remove(index, key.Length);
            }

            Console.WriteLine(text);
        }
    }
}

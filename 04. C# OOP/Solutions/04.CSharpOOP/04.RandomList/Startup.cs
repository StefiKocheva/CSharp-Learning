namespace _04.RandomList
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            var list = new RandomList<int>();

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            Console.WriteLine(list.RandomElement());

        }
    }
}

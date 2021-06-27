namespace Comparators
{
    using System;
    using System.Collections.Generic;

    public static class Startup
    {
        public static void Main()
        {
            var cats = new List<Cat>();

            cats.Add(new Cat("Ivan"));
            cats.Add(new Cat("Ana"));
            cats.Add(new Cat("Pesho"));
            cats.Add(new Cat("Gosho"));

            cats.Sort();
        }
    }
}

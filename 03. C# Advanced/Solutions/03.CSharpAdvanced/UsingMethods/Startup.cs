namespace UsingMethods
{
    using System;

    // We use static to say that this is unique class and there wouldn't be another instance of it.
    public static class Startup
    {
        public static void Main()
        {
            var person = new Person
            {
                Name = "Stephie",
                Age = 15,
            };

            Console.WriteLine(person.ToString());
        }
    }
}

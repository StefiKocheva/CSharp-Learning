namespace Inheritance
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            var animal = new Animal()
            {
                Name = "Deery",
                Age = 2,
            };

            var bitch = new Bitch()
            {
                Name = "Stephie",
                Age = 15,
            };

            bitch.Shouting();
        }
    }
}

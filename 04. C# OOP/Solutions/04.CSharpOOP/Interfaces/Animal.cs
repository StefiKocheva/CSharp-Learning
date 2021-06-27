namespace Interfaces
{
    using System;

    public class Animal : IAnimal
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public void Eat()
        {
            Console.WriteLine("Eating...");
        }

        public void Sleep()
        {
            Console.WriteLine("Sleeping...");
        }
    }
}

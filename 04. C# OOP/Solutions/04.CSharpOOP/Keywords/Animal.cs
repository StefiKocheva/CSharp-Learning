namespace Keywords
{
    using System;

    public class Animal
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public virtual void Eat()
        {
            Console.WriteLine("Eating...");
        }
    }
}

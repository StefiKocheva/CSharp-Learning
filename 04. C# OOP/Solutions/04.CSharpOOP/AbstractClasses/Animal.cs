namespace AbstractClasses
{
    using System;

    public abstract class Animal
    {
        // Can have fields, properties etc.
        public string Name { get; set; }

        public int Age { get; set; }

        // Have implementation, which can be overrided.
        // Methods should be virtual.
        public virtual void Eat()
        {
            Console.WriteLine("Eating...");
        }

        public void Sleep()
        {
            Console.WriteLine("Sleeping...");
        }
    }
}

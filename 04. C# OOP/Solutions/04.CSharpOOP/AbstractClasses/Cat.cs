namespace AbstractClasses
{
    using System;

    public class Cat : Animal
    {
        public void Meow()
        {
            Console.WriteLine("Meow...");
        }

        // Override - to change the default implementation.
        // You could override the methods from the base abstract class.
        public override void Eat()
        {
            Console.WriteLine("Eating fish...");
        }
    }
}

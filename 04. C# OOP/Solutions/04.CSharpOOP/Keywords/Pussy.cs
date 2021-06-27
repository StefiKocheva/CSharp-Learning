namespace Keywords
{
    using System;

    public class Pussy : Cat
    {
        // Forbit to inheritors of the Pussy class to override this method.
        // Always use the keyword sealed with override.
        public sealed override void Eat() => Console.WriteLine("Eating fish and bones...");
    }
}

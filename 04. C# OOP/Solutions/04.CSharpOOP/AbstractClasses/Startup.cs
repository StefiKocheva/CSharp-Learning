namespace AbstractClasses
{
    public static class Startup
    {
        public static void Main()
        {
            var cat = new Cat();

            cat.Eat(); // Eating fish... - has overrided the abstract logic.

            var dog = new Dog();

            dog.Eat(); // Eating... - execute the default abstract logic.
        }
    }
}

namespace Type
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            Cat cat = new Cat("Macinka", 2);

            // You can get the type of a class

            // Compile time
            // Namespace.ClassName
            Console.WriteLine(typeof(Cat).FullName);
            // ClassName
            Console.WriteLine(typeof(Cat).Name);

            // Runtime
            // Namespace.ClassName
            Console.WriteLine(cat.GetType().FullName);
            // ClassName
            Console.WriteLine(cat.GetType().Name);
        }
    }
}

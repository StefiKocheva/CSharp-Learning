namespace Polymorphism
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            Animal cat = new Cat();

            Animal dog = new Dog();

            Cat newCat = (Cat)cat; // Casting
        }
    }
}

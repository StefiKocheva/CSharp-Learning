namespace _03.HierarchicalInheritance
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            Dog dog = new Dog();
            dog.Eat();
            dog.Bark();

            Cat cat = new Cat();
            cat.Eat();
            cat.Meow();

        }
    }
}

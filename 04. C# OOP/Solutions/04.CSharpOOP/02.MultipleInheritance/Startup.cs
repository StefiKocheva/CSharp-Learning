namespace _02.MultipleInheritance
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            Puppy puppy = new Puppy();

            puppy.Eat();
            puppy.Bark();
            puppy.Weep();
        }
    }
}

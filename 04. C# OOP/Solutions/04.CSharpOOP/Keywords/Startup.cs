namespace Keywords
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            Animal animal = new Animal(); // Type - Animal
            Animal cat = new Cat(); // Type - Animal
            Animal pussy = new Pussy(); // Type - Animal

            // Keyword is
            if (cat is Cat)
            {
                Console.WriteLine("cat is Cat");
            }

            // Keyword as
            var cat2 = cat as Cat; // Type - Cat

            int age = 5;

            // Keyword is var
            if (age is var five)
            {
                Console.WriteLine(five); // 5
            }
        }
    }
}

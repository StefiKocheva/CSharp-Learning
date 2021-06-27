namespace CreatingClassesUsingConstructors
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            var catName = Console.ReadLine();
            var catAge = int.Parse(Console.ReadLine());
            var catColor = Console.ReadLine();

            var firstCat = new Cat(catName, catAge, catColor);
            var secondCat = new Cat(catName, catAge);

            Console.WriteLine(firstCat.Name);
        }
    }
}

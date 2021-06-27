namespace Attributes
{
    using System;
    using System.Linq;
    using System.Reflection;

    public static class Startup
    {
        public static void Main()
        {
            var cat = new Cat();

            cat.Name = "Macinka";

            // You can get the attributes of a member.
            var attributes = cat.GetType().GetProperty("Name").GetCustomAttributes().ToList();

            Console.WriteLine(cat.Name);
        }
    }
}

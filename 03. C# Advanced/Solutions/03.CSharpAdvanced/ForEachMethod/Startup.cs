namespace ForEachMethod
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public static class Startup
    {
        public static void Main()
        {
            Console
                .ReadLine()
                .Split()
                .ToList()
                .ForEach(name => Console.WriteLine(name));
        }
    }
}

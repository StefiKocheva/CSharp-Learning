namespace Func
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            Func<int, string> toString = x => x.ToString(); // Function with one parameter.
            Func<int, int, int> sum = (x, y) => x + y; // Function with more than one parameter.

            string result = toString(9);
            int finalResult = sum(4, 5);
        }
    }
}

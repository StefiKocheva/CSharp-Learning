namespace _06.CodingTracker
{
    using System;

    [Author("Venci")]
    public static class Startup
    {
        [Author("Gosho")]
        public static void Main()
        {
            var tracker = new Tracker();
            tracker.PrintMethodsByAuthor();
        }
    }
}

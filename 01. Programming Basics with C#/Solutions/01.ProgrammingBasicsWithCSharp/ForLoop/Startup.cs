namespace ForLoop
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            // i is called iterator.
            // One full looping is called iteration.
            // We use for when we know the count of iterations.
            // i++ -> Postincrementation
            // ++i -> Preincrementation
            // i-- -> Postdecrementation
            // --i -> Predecrementation
            for (int i = 0/*start*/; i < 10/*condition for end of the loop*/; i++ /*step*/)
            {
                Console.WriteLine(i); // Print the current value of i.
            }
        }
    }
}

namespace VariablesLife
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            int a = 5; // The variable a lives in the scope of the Main method, you could use it in nested scopes.

            if (a == 5)
            {
                // You could access all variables from parent scopes, for example, those in Main method.
                int b = a; // The variable b lives only in the scope of the if-clause.
            }
        }
    }
}

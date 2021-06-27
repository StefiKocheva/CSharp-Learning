namespace _06.PasswordGuess
{
    using System;
    
    public static class Startup
    {
        public static void Main()
        {
            string password = Console.ReadLine();

            if (password == "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}

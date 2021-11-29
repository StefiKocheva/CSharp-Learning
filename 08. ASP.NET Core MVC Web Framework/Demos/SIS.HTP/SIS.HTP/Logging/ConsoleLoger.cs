namespace SIS.HTTP.Logging
{
    using System;

    public class ConsoleLoger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"[{DateTime.Now.ToString()}] {message}");
        }
    }
}
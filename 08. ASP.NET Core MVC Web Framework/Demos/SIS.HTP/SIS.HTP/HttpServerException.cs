namespace SIS.HTTP
{
    using System;

    public class HttpServerException : Exception
    {
        public HttpServerException(string message)
            : base(message) // The constructor gets the base exception and give to it this message.
        {
        }
    }
}
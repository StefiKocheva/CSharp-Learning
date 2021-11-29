namespace SIS.HTTP
{
    using System.Collections.Generic;
    using System.Text;

    public class HttpResponse
    {
        public HttpResponse(HttpResponseCode statusCode, byte[] body)
            :this()
        {
            this.StatusCode = statusCode;
            this.Body = body;

            // if (body != null || body.Length > 0) - longer syntax.
            // "?" - null check if it is not null, continue with the statement.
            if (body?.Length > 0) // Shorter syntax.
            {
                this.Headers.Add(new Header("Content-Length", body.Length.ToString()));
            }
        }

        internal HttpResponse()
        {
            this.Headers = new List<Header>();

            this.Version = HttpVersionType.Http10; // Deffault version.
            this.Cookies = new List<ResponseCookie>();
        }

        public HttpVersionType Version { get; set; } // Http version of the response.
        
        public HttpResponseCode StatusCode { get; set; } // Status - status code and status string, the code is more important.

        public IList<Header> Headers { get; set; } // Same as the request headers.

        public IList<ResponseCookie> Cookies { get; set; } // To give an opportunity to those who build the response, to put some cookies inside the response.

        public byte[] Body { get; set; } // "byte[]" because we can also return an image.

        public override string ToString()
        {
            var responseAsString = new StringBuilder();

            var httpVersionAsString = this.Version switch // The version of the HTTP is the first of the first line.
            { 
                HttpVersionType.Http10 => "HTTP/1.0",
                HttpVersionType.Http11 => "HTTP/1.1",
                HttpVersionType.Http20 => "HTTP/2.0",
                _ => "HTTP/1.1",
            };

            responseAsString.Append($"{httpVersionAsString} {(int)this.StatusCode} {this.StatusCode}" + HttpConstants.NewLine); // First line of response.

            foreach (var header in this.Headers)
            {
                responseAsString.Append(header.ToString() + HttpConstants.NewLine); // Other lines.
            }

            foreach (var cookie in this.Cookies)
            {
                responseAsString.Append("Set-Cookie: " + cookie.ToString() + HttpConstants.NewLine);
            }

            // Always after the headers I have to put a new line.
            responseAsString.Append(HttpConstants.NewLine);

            return responseAsString.ToString();
        }
    }
}
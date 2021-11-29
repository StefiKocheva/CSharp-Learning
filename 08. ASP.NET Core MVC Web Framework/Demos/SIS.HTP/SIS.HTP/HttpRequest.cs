namespace SIS.HTTP
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Web;

    public class HttpRequest
    {
        // We need to parse the string to thoose bellow by using string methods.
        public HttpRequest(string httpRequestAsString)
        {
            this.Headers = new List<Header>();
            this.Cookies = new List<Cookie>();
            this.SessionData = new Dictionary<string, string>();

            // StringReader reader = new StringReader(); - class that give opportunity to read line by line.
            var lines = httpRequestAsString.Split(
                new string[] { HttpConstants.NewLine },
                StringSplitOptions.None);
            // We mustn't delete the empty entries because they are helpfull for us.

            var httpInfoHeader = lines[0];
            var infoHeaderParts = httpInfoHeader.Split(' '); // First line of request is allayws splited by two spaces. If we submit something like "te st", it would be splited with + / %.
            
            if (infoHeaderParts.Length != 3)
            {
                throw new HttpServerException("Invalid HTTP header line.");
            }

            var httpMethod = infoHeaderParts[0]; // That is the type of the request.
            // Enum.TryParse(httpMethod, out HttpMethodType type); - other way to do instead of the switch syntax.
            this.Method = httpMethod switch
            {
                "POST" => HttpMethodType.Post, 
                "GET" => HttpMethodType.Get,
                "PUT" => HttpMethodType.Put,
                "DELETE" => HttpMethodType.Delete,
                _ => HttpMethodType.Unknown,
            };

            this.Path = infoHeaderParts[1]; // The path.

            var httpVersion = infoHeaderParts[2]; // The version of the HTTP. 
            this.Version = httpVersion switch 
            { 
                "HTTP/1.0" => HttpVersionType.Http10,
                "HTTP/1.1" => HttpVersionType.Http11,
                "HTTP/2.0" => HttpVersionType.Http20,
                _ => HttpVersionType.Http11,
            };

            // That was from the first line of the request and now we continue with the others.

            // We have to know if we are inside the headers or the body.
            bool isHeader = true;

            StringBuilder bodyBuilder = new StringBuilder();

            for (int i = 1; i < lines.Length; i++) // Headers + body
            {
                var line = lines[i];

                if (string.IsNullOrWhiteSpace(line)) // One line split the header and body part, so that is how we find that line and understand that the header is ended.
                {
                    isHeader = false;

                    continue;
                }

                if (isHeader)
                {
                    // Name": "value
                    var headerParts = line.Split(new string[] { ": " }, 
                        2, // To taje propertly the name and the value in the request, we say that we want to be splitted two times.
                        StringSplitOptions.None);

                    if (headerParts.Length != 2)
                    {
                        throw new HttpServerException($"Invalid header: {line}");
                    }

                    // We have the two parts of the header and now...
                    var header = new Header(headerParts[0], headerParts[1]);
                    this.Headers.Add(header); // Add the header to our IList.

                    if (headerParts[0] == "Cookie")
                    {
                        var cookiesAsString = headerParts[1];
                        var cookies = cookiesAsString.Split(new string[] { "; " }, StringSplitOptions.None);
                        
                        foreach (var cookieAsString in cookies)
                        {
                            var cookieParts = cookieAsString.Split(new char[] { '=' }, 2);
                            
                            if (cookieParts.Length == 2)
                            {
                                this.Cookies.Add(new Cookie(cookieParts[0], cookieParts[1])); // Key and value of the cookie.
                            }
                        }
                    }
                }
                else // If it is not header, so we are inside the body part.
                {
                    bodyBuilder.AppendLine(line); // We add each line of the body which is not header.
                }
            }

            this.Body = bodyBuilder.ToString().TrimEnd('\r', '\n');
            this.FormData = new Dictionary<string, string>();
            ParseData(this.FormData, this.Body);
            
            this.Query = string.Empty;

            if (this.Path.Contains("?"))
            {
                var parts = this.Path.Split(new char[] { '?' }, 2);
                this.Path = parts[0];
                this.Query = parts[1];
            }

            this.QueryData = new Dictionary<string, string>();
            ParseData(this.QueryData, this.Query);
            /// Now the body is parsed.
        }
        private void ParseData(IDictionary<string, string> output, string input)
        {
            var dataParts = input.Split(new char[] { '&' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var dataPart in dataParts)
            {
                var parameterParts = dataPart.Split(new char[] { '=' }, 2);
                output.Add(
                    HttpUtility.UrlDecode(parameterParts[0]),
                    HttpUtility.UrlDecode(parameterParts[1]));
            }
        }


        public HttpMethodType Method { get; set; } // Type of the request.

        public string Path { get; set; } // Address we want to open.

        public HttpVersionType Version { get; set; } // Version of Http.

        // We need list of headers.
        public IList<Header> Headers { get; set; }

        // We need list of cookies. 
        public IList<Cookie> Cookies { get; set; }

        public string Body { get; set; } // Body of the request.

        public IDictionary<string, string> FormData { get; set; } // Key value of all data in the request

        public string Query { get; set; }

        public IDictionary<string, string> QueryData { get; set; } 

        public IDictionary<string, string> SessionData { get; set; }
    }
}
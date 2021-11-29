namespace HttpRequester
{
    using System;
    using System.IO;
    using System.Net;
    using System.Net.Http;
    using System.Net.Sockets;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading;
    using System.Threading.Tasks;

    public static class Stratup
    {
        public static async Task Main()
        {
            
            TcpListener tcpListener = new TcpListener(IPAddress.Loopback, 80);
            tcpListener.Start();

            while (true) // demon
            {
                TcpClient tcpClient = await tcpListener.AcceptTcpClientAsync();
#pragma warning disable CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
                Task.Run(() => 
                {
                    ProcessClientAsync(tcpClient);
                });
#pragma warning restore CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
            }
        }
        private static async Task ProcessClientAsync(TcpClient tcpClient)
        {
            const string NewLine = "\r\n"; // new line in http
            using NetworkStream networkStream = tcpClient.GetStream();
            byte[] requestBytes = new byte[1000000]; // data
            int bytesRead = await networkStream.ReadAsync(requestBytes, 0, requestBytes.Length);
            string request = Encoding.UTF8.GetString(requestBytes, 0, bytesRead); // converting from bytes[] to string
            var username = Regex.Match(request, @"Cookie: user=[^\n]*\n").Value;
            string responseText = @"<h1>" + username + "</h1>" + "<h1>" + DateTime.UtcNow + "</h1>";
            Thread.Sleep(10000);
            string response = "HTTP/1.0 200 OK" + NewLine +
                              "Server: SoftUniServer/1.0" + NewLine + // header - key: value
                              "Content-Type: text/html" + NewLine +  // what we are gonna return (text/html, image/gif, aplication/pdf and so on)
                                                                     // "Location: http://google.com" + NewLine +
                                                                     // "Content-Disposition: attachment: filename=stefi.html" + NewLine +
                              "Set-Cookie: user=Stefi" + NewLine +
                              "Content-Length: " + responseText.Length + NewLine +
                              NewLine +                             // separation from header to body
                              responseText;             // body
            byte[] responseBytes = Encoding.UTF8.GetBytes(response); // converting from string to bytes[]
            await networkStream.WriteAsync(responseBytes, 0, responseBytes.Length); ;
            Console.WriteLine(request);
            Console.WriteLine(new string('=', 60));
        }

        public static async Task HttpRequest()
        {
            HttpClient client = new HttpClient();
            // client.DefaultRequestHeaders.Add("User-Agent", "MyConsoleBrowser/1.0");
            HttpResponseMessage response = await client.GetAsync("https://softuni.bg/");
            string result = await response.Content.ReadAsStringAsync();
            Console.WriteLine(result);
            File.WriteAllText("index.html", result);
        }
    }
}
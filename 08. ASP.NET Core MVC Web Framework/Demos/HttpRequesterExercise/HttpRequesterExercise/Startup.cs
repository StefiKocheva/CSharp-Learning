namespace HttpRequesterExercise
{
    using System;
    using System.IO;
    using System.Net;
    using System.Net.Http;
    using System.Net.Sockets;
    using System.Text;
    using System.Threading.Tasks;

    public static class Startup
    {
        public static async Task Main()
        {
            const string NewLine = "\r\n";
            TcpListener tcpLlistener = new TcpListener(IPAddress.Loopback, 80);
            tcpLlistener.Start();

            while (true) // endless loop
            {
                TcpClient tcpClient = tcpLlistener.AcceptTcpClient(); // that one who want to make conection with us
                using NetworkStream networkStream = tcpClient.GetStream();
                byte[] requestBytes = new byte[1000000]; // 4096 bytes - standart
                int byetesRead = networkStream.Read(requestBytes, 0, requestBytes.Length);
                string request = Encoding.UTF8.GetString(requestBytes, 0, byetesRead);
                string responseText = @"<form action='/Account/Login' method='post'> 
<input type=date name ='date' />
<input type=text name ='username' />
<input type=password name ='password' />
<input type=submit vallue ='LOgin' />
</form>";
                string response = "HTTP/1.0 200 OK" + NewLine +
                                  "Server: SoftUniServer/1.0" + NewLine + 
                                  "Content-Type: text/html" + NewLine +
                                  // "Location: https://google.com" + NewLine +
                                  // "Content-Disposition: attachement; filename=stefi.html" + NewLine + hw + MIME
                                  "Content-Length: " + responseText.Length + NewLine +
                                  NewLine +
                                  responseText;
                byte[] responseBytes = Encoding.UTF8.GetBytes(response);
                networkStream.Write(responseBytes, 0, responseBytes.Length);
                Console.WriteLine(request);
                Console.WriteLine(new string('=', 60));
            }
        }

        public static async Task HttpRequest()
        {
            HttpClient client = new HttpClient();
            // client.DefaultRequestHeaders.Add("User-Agent", "MyConsoleBrowser/1.0");
            HttpResponseMessage response = await client.GetAsync("http://softuni.bg/");
            string result = await response.Content.ReadAsStringAsync();
            File.WriteAllText("C:\\Users\\stefa\\source\\repos\\HttpRequesterExercise\\MakeHttpRequestPartOne\\index.txt", result);
        }
    }
}

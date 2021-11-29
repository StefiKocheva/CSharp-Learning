namespace HttpRequester
{
    using System;
    using System.Collections.Generic;
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
        static Dictionary<string, int> SessionStore = new Dictionary<string, int>();
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
            // shte se zapishe v survwura - sesiq kluch stoynost sreshtu sesiqta 
            //sesiq - pomagat da navutjat nqkolko podred zaqvki (giud) sesiinno id
            //if we don't make lifetime, tq stoi samo do kraq na sesiqta / maxage
            //expires utc datetime || maxAge - lifetime og cookie
            //secure
            //ime sudurjanie domain 
            //httpOnly not visible from html / predpazva ot cross said attacks
            const string NewLine = "\r\n"; // new line in http
            using NetworkStream networkStream = tcpClient.GetStream();
            byte[] requestBytes = new byte[1000000]; // dataw 
            int bytesRead = await networkStream.ReadAsync(requestBytes, 0, requestBytes.Length);
            string request = Encoding.UTF8.GetString(requestBytes, 0, bytesRead); // converting from bytes[] to string
            //var username = Regex.Match(request, @"Cookie: user=[^\n]*\n").Value;
            var sid = Regex.Match(request, @"sid=[^\n]*\n").Value?.Replace("sid=", string.Empty.Trim());
            var newSid = Guid.NewGuid().ToString();
            //var count = 0;
            //if (SessionStore.ContainsKey(sid))
            //{
            //    SessionStore[sid]++;
            //    count = SessionStore[sid];
            //}
            //else
            //{
            //    sid = null;
            //    SessionStore[newSid] = 1;
            //    count = 1;
            //}

            //string responseText = "<h1>" + sid + "</h1>" + "<h1>" + DateTime.UtcNow + "</h1>"; 
            byte[] fileContent = File.ReadAllBytes("cat.jpg");            
            //Thread.Sleep(10000);
            string response = "HTTP/1.0 200 OK" + NewLine +
                              "Server: SoftUniServer/1.0" + NewLine + // header - key: value
                              "Content-Type: image/jpeg" + NewLine +  // what we are gonna return (text/html, image/gif, aplication/pdf and so on)
                                                                     // "Location: http://google.com" + NewLine +
                                                                     // "Content-Disposition: attachment: filename=stefi.html" + NewLine +
                              //"Set-Cookie: lang=bg; Path=/lang" + NewLine +
                              //"Set-Cookie: user=stefi; Expires="+ DateTime.UtcNow.ToString("R") + NewLine +
                              //"Set-Cookie: user=stefi; Expires="+ new DateTime(2021, 1, 1).ToString("R") + NewLine +
                              //"Set-Cookie: user=stefi; Max-Age=3600; Secure; HttpOnly;" + NewLine + // 1h = 3600 sec ne se vija ot js
                              //"Set-Cookie: user=stefi; Max-Age=3600; SameSite=Strict;" + NewLine + // 1h = 3600 sec// zabrznqvane na izprashtane na biskvitkata
                              //(string.IsNullOrWhiteSpace(sid) ?
                              //("Set-Cookie: sid=" + newSid + NewLine)
                              //: string.Empty)
                             "Content-Length: " + fileContent.Length + NewLine +
                              NewLine;             // body
            byte[] responseBytes = Encoding.UTF8.GetBytes(response); // converting from string to bytes[]
            await networkStream.WriteAsync(responseBytes); 
            await networkStream.WriteAsync(fileContent); 
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
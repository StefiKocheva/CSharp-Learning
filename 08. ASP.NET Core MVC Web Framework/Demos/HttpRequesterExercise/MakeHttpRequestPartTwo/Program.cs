namespace MakeHttpRequestPartTwo
{
    using System;
    using System.Net;
    using System.Net.Sockets;
    using System.Text;

    class Program
    {
        public static void Main()
        {
            //            const string newLine = "\r\n";
            //            TcpListener tcpListener = new TcpListener(IPAddress.Loopback, 4321);
            //            tcpListener.Start();
            //            while (true)
            //            {
            //                TcpClient tcpClient = tcpListener.AcceptTcpClient();
            //                using NetworkStream networkStream = tcpClient.GetStream();
            //                byte[] buffer = new byte[1000000];
            //                int bytesRead = networkStream.Read(buffer, 0, buffer.Length);
            //                string request = Encoding.UTF8.GetString(buffer, 0, bytesRead);
            //                string responseText = @"<h4>Here is my heading</h4>
            //<p>That is my first paragraph</p>
            //<p>That is my second paragraph</p>
            //<p>Choose your favorite Web language:</p>
            //
            //<form>
            //  <input type='radio' id='html' name='fav_language' value='HTML'>
            //  <label for='html'>HTML</label><br>
            //  <input type='radio' id='css' name='fav_language' value='CSS'>
            //  <label for='css'>CSS</label><br>
            //  <input type='radio' id='javascript' name='fav_language' value='JavaScript'>
            //  <label for='javascript'>JavaScript</label>
            //</form>
            //<form>
            //  <input type='name' name='name'>
            //  <input type='password' name='password'>
            //  <input type='submit' value='Click here to login'>
            //</form>";
            //                string response = "HTTP/1.1 200 OK" + newLine +
            //                                  "Server: SoftUniServer/1.0" + newLine +
            //                                  "Content-Type: text/html" + newLine +
            //                                  "Content-Length: " + responseText.Length + newLine +
            //                                  newLine +
            //                                  responseText;
            //                byte[] responseBytes = Encoding.UTF8.GetBytes(response);
            //                networkStream.Write(responseBytes, 0, responseBytes.Length);
            //                Console.WriteLine(request);
            //                Console.WriteLine(new string('=', 60));

            const string NewLine = "\r\n";
            TcpListener listener = new TcpListener(IPAddress.Loopback, 5674);
            listener.Start();
            while (true)
            {
                TcpClient client = listener.AcceptTcpClient();
                using NetworkStream networkStream = client.GetStream();
                byte[] bytes = new byte[1000000];
                int readBytes = networkStream.Read(bytes, 0, bytes.Length);
                string request = Encoding.UTF8.GetString(bytes, 0, readBytes);
                string responseText = @"
<h1> Hello! </h1>
<h1> Hello! </h1>
<h1> Hello! </h1>
<h1> Hello! </h1>
<h1> Hello! </h1>
<h1> Hello! </h1>
<h1> Hello! </h1>
<h1> Hello! </h1>
<h1> Hello! </h1>
<h1> Hello! </h1>
<h1> Hello! </h1>
";
                string response = "HTTP/1.1 200 OK" + NewLine +
                                  "Server: SoftUniServer/1.0" + NewLine +
                                  "Content-Type: text/javascript" + NewLine +
                                  "Content-Length: " + responseText.Length + NewLine +
                                  NewLine +
                                  responseText;
                byte[] bytesWrite = Encoding.UTF8.GetBytes(response, 0, response.Length);
                networkStream.Write(bytesWrite, 0, bytesWrite.Length);
                Console.WriteLine(response);
                Console.WriteLine(new string('=', 60));
            }
        }
    }
}

namespace MakeHttpRequestPartOne
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading.Tasks;

    public static class Startup
    {
        public static async Task Main()
        {
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage message = await httpClient.GetAsync("http://softuni.bg/");
            string response = await message.Content.ReadAsStringAsync();
            File.WriteAllText("index.html", response);
        }
    }
}

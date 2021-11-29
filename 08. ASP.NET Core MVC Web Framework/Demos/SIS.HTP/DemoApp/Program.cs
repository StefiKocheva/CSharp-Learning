namespace DemoApp
{
    using System.Threading.Tasks;
    using SIS.MvcFramework;

    public class Program
    {

        public static async Task Main()
        {
            // Actions (methods that take imformation about a request and return response): 
            // / => response IndexPage(request) 
            // /favicon.ico => favicon.ico
            // GET /Contact => response ShowContactForm(request) 
            // POST /Contact => response FillContactForm(request)

            await WebHost.StartAsync(new Startup());
        }
    }
}
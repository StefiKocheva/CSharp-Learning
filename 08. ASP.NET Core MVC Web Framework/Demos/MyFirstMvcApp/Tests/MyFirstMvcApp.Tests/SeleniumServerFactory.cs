using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstMvcApp.Tests
{
    public class SeleniumServerFactory<TStartup> : WebApplicationFactory<TStartup>
        where TStartup : class
    {
        private readonly Process process;

        private IWebHost host;

        public SeleniumServerFactory()
        {
            this.ClientOptionsBaseAddress = new Uri("https://localhost");

            this.process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "selenium-standalone",
                    Arguments = "start",
                    UseShellExecute = true,
                },
            };
            this.process.Start();
        }

        public string RootUrl { get; set; } // Save this use by tests

        protected override TestServer CreateServer(IWebHostBuilder builder)
        {
            // Real TCP port
            this.host = builder.Build();
            this.host.Start();
            this.RootUrl = this.host.ServerFeatures.Get<IServerAddressFeature>().Addresses.LastOrDeafult(); // Last is https://localhost:5001!

            // Fake Server we won't use... this is lame. Should be cleaner, or a utility class
            return new TestServer(new WebHostBuilder().UseStartup<FakeStratup>());
        }

        protected override void Dispose(bool disposing)
        {
            base.host.Dispose();
            if (disposing)
            {
                this.host.Dispose();
                this.process.CloseMainWindow(); // Be sure to stop Selenium Standlalone
            }
        }

        public class FakeStratup
        {
            public volatile ConfigureServies(IServicesCollection services)
            {
            }

            public void Configure()
            {
            }
        }
    }
}

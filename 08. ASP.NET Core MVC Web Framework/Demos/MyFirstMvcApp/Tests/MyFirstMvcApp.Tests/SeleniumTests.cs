using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstMvcApp.Tests
{
    public class SeleniumTests
    {
        [Fact]
        public void TestJs()
        {
            var browser = this.GetPage("/");
            
            var count = browser.FindElementsByCssSelector(".findMe").Count;

            Assert.Equals(10, count);
        }

        private RemoteWebDriver GetPage(string url)
        {
            var server = new SeleniumServerFactory<Startup>();
            server.CreateClient();
            var opts = new ChromeOptions();
            opts.AddArgument("--headless"); // Optional, comment this out if you want to SEE
            opts.Argument("mo-sandbox");
            var browser = new RemoteWebDriver(opts);
            //browser.Navigate().GoToUrl(server.RootUrl + "/Cars/Create");
            browser.Navigate().GoToUrl(server.RootUrl + url);

            return browser;
        }
    }
}

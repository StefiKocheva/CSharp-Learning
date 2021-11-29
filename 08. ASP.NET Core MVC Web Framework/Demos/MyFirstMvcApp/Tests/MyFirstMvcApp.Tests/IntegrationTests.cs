using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstMvcApp.Tests
{
    public class IntegrationTests
    {
        // To test our Web app
        [Fact]
        public async Task IndexPageShouldReturn200Ok()
        {
            var server = new WebApplicationfactory<Startup>();
            var client = server.CreateClient();
            var response = await client.GetAsync("/home/Index");
            var html = await response.Content.ReadAsStringAsync();
            response.EnsureSuccessStatusCode();
            //Assert.Equal(HttpStatusCode.Ok, response.StatusCode);
            Assert.Contains("<div>1</div>", html);
        }
    }
}

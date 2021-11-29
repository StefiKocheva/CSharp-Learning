using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MiddlewareDemo.Middlewares;
using System;
using System.Threading.Tasks;

namespace MiddlewareDemo
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDistributedMemoryCache();
            services.AddSession();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseWelcomePage();
            app.UseSession();
            app.Map("/SoftUni", appBuilder => // If the address starts with "/SoftUni" (prefix) and continue with "/something" or it is just "/SoftUni".
            {
                appBuilder.Run(async (context) => await context.Response.WriteAsync("Hello from SOFTUNI Map")); // Do that.
            });
            // Else, do the standard.
            //app.Use(async (context, next) =>
            //{
            //    context.Request.Path = "/Home/Error";
            //    context.Items.Add("Username", "Stefi"); // Send the data to the other middleware.
            //    context.Response.Headers.Add("X-Hello", "Hello from my middleware."); // 1)
            //    await next(); // 2), it callls... 7)
            //});
            //app.Use(async (context, next) => 
            //{
            //    await context.Response.WriteAsync("...Before..."); // this. 3)
            //    if (DateTime.UtcNow.Second % 2 == 0)
            //    {
            //        await next(); // 4), it calls...
            //        // await next(); // both times 
            //    }
            //    await context.Response.WriteAsync("...After..."); // 6)
            //    await context.Response.WriteAsync(context.Items["Username"].ToString());
            //});
            app.Use(async (context, next) =>
            {
                context.Response.OnStarting(() =>
                {
                    context.Response.Headers.Add("X-Test", "Test");
                    return Task.CompletedTask;
                });

                await next();
            });
            // app.UseMiddleware<AddInfoHeaderMiddleware>();
            app.Run(MyAppCode); // Terminal, it is run at the end. this. 5)
            // If it is here, it won't be executed, because it is after the terminal (.Run()).
            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("...Before..."); // this. 3)
            //    await next(); // 4), it calls...
            //    await context.Response.WriteAsync("...After..."); // 6)
            //});
        }

        public async Task MyAppCode(HttpContext http)
        {
            http.Session.Set("UserId", new byte[] { 0x0 });
            await http.Response.WriteAsync(http.Request.Headers["User-agent"]);
        }
    }
}

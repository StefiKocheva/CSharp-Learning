using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiddlewareDemo.Middlewares
{
    public class AddInfoHeaderMiddleware
    {
        private readonly RequestDelegate next;

        public AddInfoHeaderMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        // public void Invoke() - also valid with difference that it is not async
        public async Task InvokeAsync(HttpContext context)
        {
            // await context.Response.WriteAsync("InvokeAsync");
            // context.Response.Headers.Add("X-Length", context.Request.ContentLength.ToString());
            // context.Response.Headers.Add("X-Query", context.Request.QueryString.ToString());
            await this.next(context);
            context.Response.Headers.Add("X-Test", "Test");
        }
    }
}

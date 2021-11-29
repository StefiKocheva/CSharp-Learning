using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Authorization;
using MyFirstMvcApp.Services;

namespace MyFirstMvcApp.Filters
{
    public class MyAuthorizedFilterAttribute : Attribute,  IAuthorizationFilter
    {
        private readonly IUsersService usersService;

        public MyAuthorizedFilterAttribute(IUsersService usersService)
        {
            this.usersService = usersService;
        }
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            //if (this.usersService.GetCount() > 0)
            //{
            //    this.usersService.GetUsernames();
            //}

            if (this.usersService.GetCount() == 1)
            {
                this.usersService.GetUsernames();
            }
        }
    }

    public class MyResourceFilter : IResourceFilter
    {
        public void OnResourceExecuted(ResourceExecutedContext context)
        {
        }
        public void OnResourceExecuting(ResourceExecutingContext context)
        {
        }
    }

    public class MyResultFilter : IResultFilter
    {
        public void OnResourceExecuted(ResultExecutedContext context)
        {
        }
        public void OnResourceExecuting(ResultExecutingContext context)
        {
        }
    }

    public class MyResultFilter : IResultFilter
    {
        public void OnResourceExecuted(ResultExecutedContext context)
        {
        }
        public void OnResourceExecuting(ResultExecutingContext context)
        {
        }
    }

    public class MyExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
        }
    }

    //public class MyActionFilter : ActionFilterAttribute // all in one
    //{
    //    public override void OnActionExecuting(ActionExecutingContext context)
    //    {
    //        base.OnActionExecuting(context);
    //    }
    //}
    public class AddHeaderAttribute : Attribute, IAsyncActionFilter, IAsyncPageFilter
    {
        private readonly string header;
        private readonly string value;

        public AddHeaderAttribute(string header, string value)
        {
            this.header = header;
            this.value = value;
        }
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            //context.HttpContext.Response.Headers.Add(this.header, this.value);
            //await next();
        }

        public async Task OnPageHandlerExecutionAsync(PageHandlerExecutedContext context, PageHandlerExecutionDelegate next)
        {
            //context.HttpContext.Response.Headers.Add(this.header, this.value);
            //await next();
        }

        public Task OnPageHandlerSelectionAsync(PageHandlerSelectedContext context)
        {
            return this.CompletedTask;
        }
    }
    public class ValidateModelStateFilterAttribute : Attribute, IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                context.Result = new JsonResult("Invalid model state");
            }
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
        }
    }
}

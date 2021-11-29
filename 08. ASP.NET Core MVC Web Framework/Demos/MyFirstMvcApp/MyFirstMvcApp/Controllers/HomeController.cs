using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyFirstMvcApp.Data;
using MyFirstMvcApp.Filters;
using MyFirstMvcApp.Models;
using MyFirstMvcApp.Models.Home;
using MyFirstMvcApp.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstMvcApp.Controllers
{
    // [AddHeader("X-Debug", "Work")]
    // [TypeFilterAttribute(typeof(MyAuthorizedFilterAttribute))]
    [ServiceFilter(typeof(MyAuthorizedFilterAttribute))] // To have controll on the instation type.
    // [TypeFilterAttribute(typeof(MyAuthorizedFilterAttribute), Arguments = new string[] {"", ""}))] // with parameters
    public class HomeController : Controller
    {
        private readonly IUsersService usersService;
        private readonly ICounterService counterService;
        private readonly ILogger<HomeController> logger;

        public HomeController(
            IUsersService usersService,
            ICounterService counterService,
            ILogger<HomeController> logger)
        {
            this.usersService = usersService;
            this.counterService = counterService;
            this.logger = logger;
        }

        public IActionResult Index(int id)
        {
            if (id == 0)
            {
                //this.logger.LogDebug($"Id is {id}");
                //this.logger.LogTrace($"Id is {id}"); // appsettings.Delelopment configure this file
                this.logger.LogWarning($"Id is {id}");
            }
            var usernames = this.usersService.GetUsernames();
            var viewModel = new IndexViewModel { Usernames = usernames };
            return View();
            // Logging Levels
            // Tace - information
            // Debug - ifno, usefull in development and debugging
            // Information - the steps of the program
            // Warning - unexpected events in the app flow
            // Errors - for errors and exceptions that cannot be handled
            // Critical - for failures that requires immediate attention
            // To use we inject ILogger
        }

        [ValidateModelStateFilter]
        public IActionResult AcceptForm(FormInputModel input)
        {
            if (!ModelState.IsValid)
            {
                return this.Content("Not Ok!");
            }
            return this.Content("Ok!");
        }
        public IActionResult Errors(string code)
        {
            return this.Content(code);
        }

        //[AddHeader("X-Debug", "Works")]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

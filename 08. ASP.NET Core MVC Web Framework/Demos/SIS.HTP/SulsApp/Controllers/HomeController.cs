namespace SulsApp.Controllers
{
    using SIS.HTTP;
    using SIS.HTTP.Logging;
    using SIS.MvcFramework;
    using SulsApp.ViewModels;
    using SulsApp.ViewModels.Home;
    using System;
    using System.Linq;

    public class HomeController : Controller
    {
        private readonly ILogger logger;
        private readonly ApplicationDbContext db;

        public HomeController(ILogger logger, ApplicationDbContext db)
        {
            this.logger = logger;
            this.db = db;
        }
        // Home/Index
        // /
        [HttpGet("/")]
        public HttpResponse Index()
        {
            if (this.IsUserLogedIn())
            {
                var problems = db.Problems.Select(x => new IndexProblemViewModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    Count = x.Submissions.Count(),
                }).ToList();

                var loggedInViewModel = new LoggedInViewModel()
                {
                    Problems = problems,
                };

                return this.View(loggedInViewModel, "IndexLoggedIn");
            }

            this.logger.Log("Hello from Index");
            var viewModel = new IndexViewModel()
            {
                Message = "Welcome to SULS Platform",
                Yaer = DateTime.UtcNow.Year,
            };

            return this.View(viewModel);
        }
    }
}
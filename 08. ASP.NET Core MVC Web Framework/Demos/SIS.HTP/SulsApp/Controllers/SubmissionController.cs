namespace SulsApp.Controllers
{
    using SIS.HTTP;
    using SIS.MvcFramework;
    using SulsApp.Services;
    using SulsApp.ViewModels.Submissions;
    using System.Linq;

    public class SubmissionController : Controller
    {
        private readonly ApplicationDbContext db;
        private readonly ISubmissionService submissionService;

        public SubmissionController(ApplicationDbContext db, ISubmissionService submissionService)
        {
            this.db = db;
            this.submissionService = submissionService;
        }

        public HttpResponse Create(string id)
        {
            if (!this.IsUserLogedIn())
            {
                return this.Redirect("/Users/Login");
            }

            var problem = this.db.Problems
                .Where(x => x.Id == id)
                .Select(x => new CreateFormViewModel
                {
                    Name = x.Name,
                    ProblemId = x.Id,
                }).FirstOrDefault();

            if (problem == null)
            {
                return this.Error("problem not found");
            }

            return this.View(problem);
        }

        [HttpPost]
        public HttpResponse Create(string problemId, string code)
        {
            if (!this.IsUserLogedIn())
            {
                return this.Redirect("/Users/Login");
            }

            if (code == null || code.Length < 30)
            {
                return this.Error("Please provide code with at least 30 characters.");
            }

            this.submissionService.Create(this.User, problemId, code);

            return Redirect("/");
        }

        public HttpResponse Delete(string id)
        {
            if (!this.IsUserLogedIn())
            {
                return this.Redirect("/Users/Login");
            }

            this.submissionService.Delete(id);

            return this.Redirect("/");
        }
    }
}
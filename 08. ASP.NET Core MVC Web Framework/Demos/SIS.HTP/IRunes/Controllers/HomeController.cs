namespace IRunes.Controllers
{
    using IRunes.Services;
    using IRunes.ViewModels.Home;
    using SIS.HTTP;
    using SIS.MvcFramework;

    public class HomeController : Controller
    {
        private readonly IUsersService usersService;

        public HomeController(IUsersService usersService)
        {
            this.usersService = usersService;
        }

        [HttpGet("/")]
        [HttpGet("/Home/Index")]
        public HttpResponse Index()
        {
            if (this.IsUserLogedIn())
            {
                var viewModel = new IndexViewModel();
                viewModel.Username = this.usersService.GetUsername(this.User);
                
                return this.View(viewModel, "Home");
            }

            return this.View();
        }
    }
}
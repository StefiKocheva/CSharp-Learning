﻿namespace IRunes.Controllers
{
    using IRunes.Services;
    using IRunes.ViewModels.Users;
    using SIS.HTTP;
    using SIS.MvcFramework;

    public class UsersController : Controller
    {
        private readonly IUsersService usersService;

        public UsersController(IUsersService usersService)
        {
            this.usersService = usersService;
        }

        public HttpResponse Login()
        {
            return this.View();
        }

        [HttpPost]
        public HttpResponse Login(LoginInputModel input)
        {
            var userId = this.usersService.GetUserId(input.Username, input.Password);
            
            if (userId != null)
            {
                this.SignIn(userId);
                return this.Redirect("/");
            }

            return this.Redirect("/Users/Login");
        }

        public HttpResponse Register()
        {
            return this.View();
        }

        [HttpPost]
        public HttpResponse Register(RegisterInputModel input)
        {
            if (string.IsNullOrWhiteSpace(input.Email))
            {
                return this.Error("Email cannot be empty!");
            }

            if (input.Username.Length < 4 || input.Username.Length > 10)
            {
                return this.Error("Password must be at least 6 characters and at most 20!");
            }

            if (input.Password != input.ConfirmPassword)
            {
                return this.Error("Password should match!");
            }

            if (this.usersService.EmailExists(input.Email))
            {
                return this.Error("Email already in use!");
            }

            if (this.usersService.EmailExists(input.Username))
            {
                return this.Error("Username already in use!");
            }

            this.usersService.Register(input.Username, input.Email, input.Password);

            return this.Redirect("/Users/Login");
        }

        public HttpResponse Logout()
        {
            this.SignOut();
            return this.Redirect("/");
        }
    }
}
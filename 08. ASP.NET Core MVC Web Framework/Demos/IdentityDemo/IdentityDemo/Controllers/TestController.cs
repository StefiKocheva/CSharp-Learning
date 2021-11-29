using IdentityDemo.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace IdentityDemo.Controllers
{
    public class TestController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly RoleManager<ApplicationUser> roleManager;

        public TestController(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            RoleManager<ApplicationUser> roleManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
        }
        // For global use
        //[Authorize(Roles = "Admin")] // only for admins
        [Authorize] // only for logged users
        //[Authorize(Policy = "")] 
        public IActionResult ShowMoreAdmins()
        {
            return this.Ok("Welkome admin!");
        }

        // Creating user with code
        public async Task<IActionResult> CreateUser()
        {
            // For creating user
            //var result = await this.userManager.CreateAsync(new IdentityUser()
            //{
            //    Email = "stefikocheva2005@gmail.com",
            //    UserName = "Stefi_Kocheva",
            //    EmailConfirmed = true,
            //    PhoneNumber = "089 706 5699",
            //}, "123456");
            //
            //if (!result.Succeeded)
            //{
            //    return this.BadRequest(string.Join("; ", result.Errors.Select(x => x.Description)));
            //}
            //
            //var result2 = await this.signInManager.PasswordSignInAsync("Stefi_Kocheva", "123456", true, false);

            //if (this.User.Identity.IsAuthenticated)
            //{
            //
            //}

            //var dbUser = await this.userManager.GetUserAsync(this.User);
            
            //if (this.User.IsInRole("Admin")) 
            //{
            //
            //}

            var userId = this.userManager.GetUserId(this.User);
            
            //ClaimTypes.

            //await this.roleManager.CreateAsync(new IdentityRole { Name = "Admin" });
            var user = await this.userManager.GetUserAsync(this.User);
            await this.userManager.AddToRoleAsync(user, "Admin");

            return this.Ok();
        }
    }
}

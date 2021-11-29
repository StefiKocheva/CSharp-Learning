using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstMvcApp.Controllers
{
    // Identity/Account/Login
    // Area/Controller/Action
    // Conroller/Action
    public class TempDataFormInputModel
    {
        public string Message { get; set; }

        public IEnumerable<IFormFile> Files { get; set; } // with name="files"
    }

    // Post-Redirect-Get design pattern
    public class TempDataController : Controller
    {
        private readonly IHostingEnvironment environment;

        public TempDataController(IHostingEnvironment environment) // To take the path to my static files
        {
            this.environment = environment;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SendForm(TempDataFormInputModel input)
        {
            if (!ModelState.IsValid)
            {
                return this.View();
            }

            // Work with files
            // Good to have SQL table with meta info about the files (Users - Id and make reference between Users and Files (Id - Guid) (byte[] but not recommended to save the files in SQL)
            System.IO.Directory.CreateDirectory(environment.WebRootPath + "/Files"); // To ensure that there is such folder
            using var file = System.IO.File.OpenWrite(environment.WebRootPath + "/Files/text.txt");
            // input.Files.First().Length > To forbid a big size files
            input.Files.First().CopyTo(file); 

            // Save to db
            this.TempData["message"] = input.Message;
            return this.Redirect("ThankYou");
        }

        public IActionResult ThankYou()
        {
            //var message = this.TempData["message"];
            //return this.View(message);

            // using var file = System.IO.File.OpenRead(environment.WebRootPath + "/Files/text.txt"); use File below not PhysicalFile
            return this.PhysicalFile(environment.WebRootPath + "/Files/text.txt", "text/plain");
        }
    }
}

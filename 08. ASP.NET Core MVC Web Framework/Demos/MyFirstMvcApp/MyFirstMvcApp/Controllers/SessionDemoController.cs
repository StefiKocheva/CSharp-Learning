using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Text;

namespace MyFirstMvcApp.Controllers
{
    [Serializable]
    public class Name
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
    public class SessionDemoController : Controller
    {
        public IActionResult Save()
        {
            var name = new Name { FirstName = "Stefi", LastName = "Kocheva" };
            var nameAsString = JsonConvert.SerializeObject(name);
            var nameAsByteArray = Encoding.UTF8.GetBytes(nameAsString);

            this.HttpContext.Session.Set("key", nameAsByteArray);
            return this.Ok();
        }

        public IActionResult Load()
        {
            this.HttpContext.Session.TryGetValue("key", out var data);
            var nameAsString = Encoding.UTF8.GetString(data);
            // Encoding - from string to byte array
            var name = JsonConvert.DeserializeObject<Name>(nameAsString);
            return this.Content(name.FirstName + " " + name.LastName);
        }
    }
}

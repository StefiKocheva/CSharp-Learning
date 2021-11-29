using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiDemo.Configuration;

namespace WebApiDemo.Controllers
{
    public class ValuesController : Controller
    {

        //GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "";
        }
    }
}

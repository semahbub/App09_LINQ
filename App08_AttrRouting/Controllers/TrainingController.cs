using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace App08_AttrRouting.Controllers
{
    public class TrainingController : Controller
    {
        [Route("")]
        [Route("/Home")]
        [Route("/Home/index")]
        public IActionResult Index()
        {
            string[] courselist = {"C# Programming", "ASP.NET Core MVC", "JavaScript Programming", "SQL Server" };

            return View(courselist);
        }

        public IActionResult Data()
        {
            return View();
        }

    }
}
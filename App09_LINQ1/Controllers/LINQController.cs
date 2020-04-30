using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace App09_LINQ1.Controllers
{
    public class LINQController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Example1()
        {
            int[] numbers = { 8, 5, 6, 3, 7, 8, 2, 0, 1, 2 };

            var lownumber = from n in numbers
                            where n < 7
                            select n;

            return View(lownumber);
        }

        public IActionResult Example2()
        {
            int[] numbers = { 8, 5, 6, 3, 7, 8, 2, 0, 1, 2 };

            var lownumber = from n in numbers
                            where n < 6
                            select n*10;

            return View("Example1", lownumber);
        }

        public IActionResult Example3(string utext)
        {
            string[] courselist = { "C# Programming", 
                                    "ASP.NET Core MVC", 
                                    "JavaScript Programming",
                                    "C++ Programming",
                                    "Angular 9 Tutorial",
                                    "React Programming",
                                    "JQuery for Developers",
                                    "Vue as Javascript Library",
                                    "NodeJS for Backend Developers",
                                    "SQL Server" 
                                  };

            if (!string.IsNullOrEmpty(utext))
            {
                var selectedcourse = from c in courselist
                                     where c.ToLower().Contains(utext.ToLower())
                                     select c;

                return View(selectedcourse);
            }
            else
            {
                return View();
            }
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using ASPNET5noauth.Models;

namespace ASPNET5noauth.Controllers
{



    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Foo()
        {
            ViewData["Message"] = "This is the message for FOO.";
            ViewData["FooMsg"] = "Foo Message";
            return View();
        }

        [HttpGet]
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            var p = new Person()
            {
                FirstName = "Roger",
                LastName = "Layton",
                Birthdate = new DateTime(1953, 3, 19)
            };

            return View(p);
        }

        [HttpPost]
        public IActionResult About(Person personIn)
        {
            return View(personIn);
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AtHomeStore.Models;
using Microsoft.AspNetCore.Authorization;

namespace AtHomeStore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Products()
        {
            ViewData["Message"] = "Products Page.";

            return View();
        }

        public IActionResult FAQ()
        {
            ViewData["Message"] = "Burning Questions.";

            return View();
        }

        public IActionResult Profile()
        {
            ViewData["Message"] = "Personal Page.";

            return View();
        }

        //[Authorize(Roles = "")]
        public IActionResult Cart()
        {
            ViewData["Message"] = "Cart full of goodies.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstResponsiveWebAppBrannen.Models;

// Jeremy Brannen

namespace FirstResponsiveWebAppBrannen.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
              //available to controllers and views
            ViewBag.Age = 0;
            return View();
        }
        [HttpPost]
        public IActionResult Index(AgeCalculator model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Age = model.CalculateAge();
            }
            else
            {
                ViewBag.Age = 0;
            }

            return View(model);
        }
    }
}

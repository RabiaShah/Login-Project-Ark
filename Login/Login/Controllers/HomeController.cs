using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Login.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Login.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public IActionResult Login(ErrorViewModel model)
        {
            if(model.Email== "raza.hashmi@ark.re" && model.Password=="Testrun123")
            {
                return View("Successful");
            }
            else
            {
                return View("Unsuccessful");
            }
        }

        [HttpGet,HttpPost]
        public IActionResult Index(ErrorViewModel model)
        {
            if(model.Email==null || model.Password==null)
            {
                return View();
            }
            else if (model.Email == "raza.hashmi@ark.re" && model.Password == "Testrun123")
            {
                return View("Successful");
            }
            else
            {
                return View("Unsuccessful");
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

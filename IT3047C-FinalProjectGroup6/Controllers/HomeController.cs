using IT3047C_FinalProjectGroup6.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace IT3047C_FinalProjectGroup6.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

<<<<<<< HEAD
        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult Recipe()
=======
        public IActionResult Cooking()
>>>>>>> f1be7e073d9509a21525d35b7075461ac25061e9
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
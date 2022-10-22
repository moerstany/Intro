using System.Diagnostics;
using Intro.Models;
using Microsoft.AspNetCore.Mvc;

namespace Intro.Controllers
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
        public IActionResult Test()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult IndexContent()
        {
            return Content("sss");
        }
        public IActionResult IndexJson()
        {
            return Json("sss");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
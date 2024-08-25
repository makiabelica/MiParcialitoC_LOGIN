using Microsoft.AspNetCore.Mvc;
using MiParcialitoEC100521Login.Models;
using System.Diagnostics;

namespace MiParcialitoEC100521Login.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Login(string email, string password, bool remember)
        {
            return RedirectToAction("Privacy", "Home");
        }
    }
}

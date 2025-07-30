using _01_MVC_Giris.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _01_MVC_Giris.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //Metod
        // Action = dönüþ tipi IActionResult olan metod
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Deneme()
        {
            return View();
        }

    }
}

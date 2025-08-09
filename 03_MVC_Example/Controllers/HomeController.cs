using _03_MVC_Example.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _03_MVC_Example.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

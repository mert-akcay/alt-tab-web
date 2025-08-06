using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _02_MVC_Example.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Baslik = "Anasayfa";
            return View();
        }
    }
}

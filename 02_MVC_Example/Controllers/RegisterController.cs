using _02_MVC_Example.Models;
using Microsoft.AspNetCore.Mvc;

namespace _02_MVC_Example.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Baslik = "Kayıt Sayfası";
            return View();
        }

        [HttpPost]
        public IActionResult Index(User user)
        {
            return RedirectToAction("Welcome", user);
        }

        public IActionResult Welcome(User user)
        {
            ViewBag.Baslik = $"Hoş geldiniz {user.Ad} {user.Soyad}";
            return View(user);
        }
    }
}

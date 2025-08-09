using Microsoft.AspNetCore.Mvc;
using _03_MVC_Example.Models;

namespace TestMVC_3.Controllers
{
    public class SurveyController : Controller
    {
        private static List<SurveyOption> secenekler = new()
        {
            new SurveyOption { Secenek = "C#", OySayisi = 0 },
            new SurveyOption { Secenek = "Java", OySayisi = 0 },
            new SurveyOption { Secenek = "Python", OySayisi = 0 },
            new SurveyOption { Secenek = "JavaScript", OySayisi = 0 },
        };

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Baslik = "Mini Anket";
            return View(secenekler);
        }

        [HttpPost]
        public IActionResult Index(string secilenSecenek)
        {
            var secilen = secenekler.FirstOrDefault(x => x.Secenek == secilenSecenek);
            if (secilen != null)
            {
                secilen.OySayisi++;
                TempData["Tesekkur"] = "Oyunuz için teşekkür ederiz!";
            }

            return RedirectToAction("Index");
        }
    }
}

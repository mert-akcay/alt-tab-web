using _04_MVC_EFCore.Core.Contexts;
using _04_MVC_EFCore.Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace _04_MVC_EFCore.Controllers
{
    public class KitapController(ApplicationDbContext context) : Controller
    {
        public IActionResult Index()
        {
            var kitaplar = context.Kitap.ToList();
            return View(kitaplar);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Kitap kitap)
        {               
            context.Add(kitap);
            context.SaveChanges();

            return View();
        }

        public IActionResult Edit(int id)
        {
            var kitap = context.Kitap.Find(id);
            return View(kitap);
        }

        [HttpPost]
        public IActionResult Edit(Kitap kitap)
        {
            context.Update(kitap);
            context.SaveChanges();

            return View();
        }
    }
}

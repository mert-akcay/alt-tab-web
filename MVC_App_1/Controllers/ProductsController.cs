using Microsoft.AspNetCore.Mvc;
using MVC_App_1.Core.Contexts;
using MVC_App_1.Core.Entities;

namespace MVC_App_1.Controllers
{
    public class ProductsController(ApplicationDbContext context) : Controller
    {

        public IActionResult Index()
        {
            var products = context.Products.ToList();
            return View(products);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            context.Add(product);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var product = context.Products.Find(id);
            return View(product);
        }
    }
}

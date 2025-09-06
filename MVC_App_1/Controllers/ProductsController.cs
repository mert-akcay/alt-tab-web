using Microsoft.AspNetCore.Mvc;
using MVC_App_1.Core.Contexts;
using MVC_App_1.Core.Entities;

namespace MVC_App_1.Controllers
{
    public class ProductsController(ApplicationDbContext context) : Controller
    {
        [HttpGet]
        public IActionResult Index(string name, decimal? minPrice, decimal? maxPrice)
        {
            var query = context.Products.AsQueryable();

            if (!string.IsNullOrWhiteSpace(name))
            {
                query = query.Where(product => product.Name.Contains(name));
            }

            if (minPrice.HasValue)
            {
                query = query.Where(product => product.Price >= minPrice.Value);
            }

            if (maxPrice.HasValue)
            {
                query = query.Where(product => product.Price <= maxPrice.Value);
            }

            var products = query.ToList();

            return View((products, name, minPrice, maxPrice));
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                context.Products.Add(product);
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            // If validation fails, return same view with errors
            return View(product);
        }


        [HttpGet]
        public IActionResult Details(int id)
        {
            var product = context.Products.Find(id);
            return View(product);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var product = context.Products.Find(id);
            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Product product)
        {
            if (!ModelState.IsValid)
            {
                // Validation failed → show form again with errors
                return View(product);
            }

            context.Products.Update(product);
            context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }


        //[HttpGet]
        //public IActionResult Delete(int id)
        //{
        //	var product = context.Products.Find(id);
        //	return View(product);
        //}

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var product = context.Products.Find(id);

            if (product != null)
            {
                context.Products.Remove(product);
                context.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}

//1. Yöntem: Bütün kayıtları çekip, sonrasında filtreleme yapmak. Gereksiz kayıtlar da gelir, performans çok düşük.
//var products = context.Products.ToList();
//products.Where(x=>x.Name == name);

//2. Yöntem: Daha okunaklı ama daha fazla kod yazılan yöntem. 3. yöntemle arasında performans farkı yok.
//var products = context.Products.AsQueryable();
//products.Where(x=>x.Name == name);
//products.OrderBy(x => x.Name);
//products.ToList();

//3. Yöntem: Tek satırda filtreleme işlemi, tercih edilen
//var products = context.Products.Where(product => product.Name == name || product.Name.Contains(name)).ToList();

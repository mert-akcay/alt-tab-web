using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC_App_2.Core.Contexts;
using MVC_App_2.Core.Entities;
using MVC_App_2.Models;

namespace MVC_App_2.Controllers
{
    public class AuthorController(ApplicationDbContext context) : Controller
    {
        public IActionResult Index()
        {
            var authors = context.Authors.ToList();
            return View(authors);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Author author)
        {
            context.Authors.Add(author);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

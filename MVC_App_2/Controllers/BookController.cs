using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_App_2.Core.Contexts;
using MVC_App_2.Core.Entities;
using MVC_App_2.Models;
using MVC_App_2.ViewModels;

namespace MVC_App_2.Controllers
{
    public class BookController(ApplicationDbContext context) : Controller
    {
        public IActionResult Index()
        {
            //Predicate
            //Arrow Function
            var books = context.Books.Include(x => x.Author).ToList();
            return View(books);
        }

        public IActionResult Create()
        {
            var authors = context.Authors.ToList();

            var createViewModel = new BookCreateViewModel();
            createViewModel.Authors = authors;

            return View(createViewModel);
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            context.Books.Add(book);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

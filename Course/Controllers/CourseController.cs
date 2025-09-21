using Course.Core.Contexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Course.Controllers
{
    public class CourseController(ApplicationDbContext context) : Controller
    {
        public IActionResult Index()
        {
            var courses = context.Courses.Include(x => x.Instructor).ToList();
            return View(courses);
        }
    }
}

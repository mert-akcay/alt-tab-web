using Microsoft.EntityFrameworkCore;
using Course.Core.Entities;

namespace Course.Core.Contexts
{
    public class ApplicationDbContext :  DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options)
        {
        }

        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Course.Core.Entities.Course> Courses { get; set; }
    }
}

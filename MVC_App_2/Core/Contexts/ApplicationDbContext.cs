using Microsoft.EntityFrameworkCore;
using MVC_App_2.Core.Entities;

namespace MVC_App_2.Core.Contexts
{
    public class ApplicationDbContext :  DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
    }
}

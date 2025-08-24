using Microsoft.EntityFrameworkCore;
using MVC_App_1.Core.Entities;

namespace MVC_App_1.Core.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}

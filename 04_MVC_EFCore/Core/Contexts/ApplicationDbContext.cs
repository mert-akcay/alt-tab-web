using _04_MVC_EFCore.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace _04_MVC_EFCore.Core.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Kitap> Kitap { get; set; }
        public DbSet<Yazar> Yazar { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kitap>(entity =>
            {
                entity.Property(k => k.Ad)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(k => k.Fiyat)
                    .IsRequired()
                    .HasPrecision(18, 2);
            });

            modelBuilder.Entity<Yazar>(entity =>
            {
                entity.Property(y => y.Ad)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(y => y.Soyad)
                    .IsRequired()
                    .HasMaxLength(50);
            });
        }
    }
}

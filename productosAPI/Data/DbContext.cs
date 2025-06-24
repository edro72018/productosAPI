using Microsoft.EntityFrameworkCore;
using productosAPI.Models;

namespace productosAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Producto> Productos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Producto>()
            .Property(p => p.Precio)
            .HasColumnType("decimal(6,2)");
            base.OnModelCreating(modelBuilder);
        }
    }


}

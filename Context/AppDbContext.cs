using Microsoft.EntityFrameworkCore;
using MiCrudApi.Models;

namespace MiCrudApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // Add your DbSet properties here
        // Example:
        // public DbSet<YourModel> YourModels { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
    }
}
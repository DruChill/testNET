using Microsoft.EntityFrameworkCore;
using MicrudApi.Models;

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
        public DbSet<Person> Persons { get; set; }
    }
}
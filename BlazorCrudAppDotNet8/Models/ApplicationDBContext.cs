using Microsoft.EntityFrameworkCore;

namespace BlazorCrudAppDotNet8.Models
{
    public class ApplicationDBContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=HASIBSHANTO;Database=BlazorDb;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=True");
        }

        public DbSet<Product> Products { get; set; }
    }
}

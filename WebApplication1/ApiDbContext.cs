using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {
                Database.EnsureCreated();
        }
        public DbSet<Produits> Produitsss { get { return Set<Produits>(); } }
    }
}

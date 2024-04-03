using Microsoft.EntityFrameworkCore;

namespace api_RegistroDePonto.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base (options)
        {                
        }

        public DbSet<RegistroDePonto> RegistroDePonto { get; set; }
    }
}

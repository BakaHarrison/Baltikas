using Microsoft.EntityFrameworkCore;
using WebApplication1.Model;
using WebApplication1.Model.AuthApp;

namespace WebApplication1.Repository
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Baltika> Beer { get; set; }
        public DbSet<AuthUser>? AuthUsers { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;

namespace NotasApp.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Nota> Notas { get; set; }
        public DbSet<User> Users { get; set; }
    }
}

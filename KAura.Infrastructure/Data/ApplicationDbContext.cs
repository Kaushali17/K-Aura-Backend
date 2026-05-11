using KAura.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace KAura.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users => Set<User>();
    }
}

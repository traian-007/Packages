using Microsoft.EntityFrameworkCore;
using Packages.Domain.Entities;

namespace Packages.Infrastructure.Data
{
    public class PackagesDbContext : DbContext
    {
        public PackagesDbContext(DbContextOptions<PackagesDbContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customer { get; set; }
    }
}

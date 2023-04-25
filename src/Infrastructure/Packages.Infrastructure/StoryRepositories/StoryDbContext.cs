using Microsoft.EntityFrameworkCore;
using Packages.Domain.StoryDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Packages.Repository.StoryRepositories
{
    public class StoryDbContext : DbContext
    {
       /* public StoryDbContext(DbContextOptions<StoryDbContext> options) : base(options)
        {

        }

        public DbSet<Story> Story { get; set; }*/
    }
}

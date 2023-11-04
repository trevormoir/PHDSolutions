using Microsoft.EntityFrameworkCore;
using PHDSolutions.Shared;

namespace PHDSolutions.Server.Data
{
    public class PHDSolutionsContext : DbContext
    {
        public PHDSolutionsContext(DbContextOptions<PHDSolutionsContext> options) : base(options)
        {

        }

        public DbSet<MaterialMaster> MaterialMaster { get; set; }
        public DbSet<ProjectRecord> ProjectRecord { get; set; }
        public DbSet<PurchaseRecord> PurchaseRecord { get; set; }
        public DbSet<User> Users { get; set; }

    }
}

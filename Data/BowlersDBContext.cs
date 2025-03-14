using Microsoft.EntityFrameworkCore;

namespace FullStackFun.Data
{
    public class BowlersDBContext : DbContext
    {
        public BowlersDBContext(DbContextOptions<BowlersDBContext> options) : base(options)
        {
        }
        public DbSet<Bowlers> Bowlers { get; set; }
        public DbSet<Teams> Teams { get; set; }
    }
}

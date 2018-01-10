using Microsoft.EntityFrameworkCore;
using vegas.Models;

namespace vegas.Persistence
{
    public class VegasDbContext : DbContext
    {
        public VegasDbContext(DbContextOptions<VegasDbContext> options) : base(options)
        {            
        }

        public DbSet<Make> Makes { get; set; }
    }
}
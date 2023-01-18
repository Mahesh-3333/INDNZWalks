using INDNZWalks.API.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace INDNZWalks.API.Data
{
    public class INDNZWalksDbContext : DbContext
    {
        public INDNZWalksDbContext(DbContextOptions<INDNZWalksDbContext> options) : base(options)
        {

        }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }
        public DbSet<WalkDifficulty> WalkDifficulty { get; set; }
    }
}

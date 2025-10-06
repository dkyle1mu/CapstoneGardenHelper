using Microsoft.EntityFrameworkCore;

namespace GardenHelper.Server
{
    public class PlantDbContext : DbContext
    {
        public DbSet<Plant> Garden {  get; set; }

        public PlantDbContext(DbContextOptions<PlantDbContext> options) : base(options) { }
    }
}

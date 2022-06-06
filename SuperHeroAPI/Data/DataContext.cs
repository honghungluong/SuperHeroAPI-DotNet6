global using Microsoft.EntityFrameworkCore; // ??? what does global mean

namespace SuperHeroAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<SuperHero> SuperHeroes { get; set; }
        public DbSet<Enemy> Enemies { get; set; }

    }
}

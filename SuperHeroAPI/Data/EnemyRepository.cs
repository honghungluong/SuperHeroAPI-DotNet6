using SuperHeroAPI.Interfaces;

namespace SuperHeroAPI.Data
{
    public class EnemyRepository : BaseCrudRepository<Enemy>, IEnemyRepository
    {
        public EnemyRepository(DataContext context) : base(context)
        {
        }
    }
}

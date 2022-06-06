using SuperHeroAPI.Interfaces;

namespace SuperHeroAPI.Data
{
    public class BaseCrudRepository<T> : IBaseCrudRepository<T> where T : class
    {
        private readonly DataContext _context;
        protected readonly DbSet<T> _dbSet;

        public BaseCrudRepository(DataContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>(); // study
        }

        public async Task<T> CreateAsync(T entity)
        {
            try
            {
                await _dbSet.AddAsync(entity);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            return entity;

        }

        public async Task<T> UpdateAsync(T entity)
        {
            try
            {
                _dbSet.Update(entity);
                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;               
            }
            return entity;
        }
    }
}

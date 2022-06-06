namespace SuperHeroAPI.Interfaces
{
    public interface IBaseCrudRepository<T> where T : class
    {
        Task<T> CreateAsync(T entity);  
        Task<T> UpdateAsync(T entity);  


    }
}

using System.Linq.Expressions;

namespace Api_Task_Techtroll.co.Application.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<T?> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate);
        Task<bool> AnyAsync(Expression<Func<T, bool>> predicate);
        Task<IEnumerable<T>> GetAllWithIncludeAsync(params Expression<Func<T, object>>[] includes);
        public IQueryable<T> GetQueryable();

        Task AddAsync(T entity);
        void Update(T entity);
        void Remove(T entity);
    }
}

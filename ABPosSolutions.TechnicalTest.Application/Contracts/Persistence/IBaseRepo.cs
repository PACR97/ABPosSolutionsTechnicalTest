using ABPosSolutions.TechnicalTest.Domain.Common;
using System.Linq.Expressions;

namespace ABPosSolutions.TechnicalTest.Application.Contracts.Persistence
{
    public interface IBaseRepo<TKey,TEntity> where TEntity : BaseDomainModel
    {
        Task<List<TEntity>> GetAllAsync();

        Task<List<TEntity>> GetAsync(Expression<Func<TEntity, bool>> predicate);

        Task<List<TEntity>> GetAsync(Expression<Func<TEntity, bool>>? predicate = null,
                                       Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null,
                                       string? includeString = null,
                                       bool disableTracking = true);

        Task<List<TEntity>> GetAsync(Expression<Func<TEntity, bool>>? predicate = null,
                                       Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null,
                                       List<Expression<Func<TEntity, object>>>? includes = null,
                                       bool disableTracking = true);

        Task<TEntity?> GetByIdAsync(TKey id);

        Task<TEntity> AddAsync(TEntity entity);

        TEntity UpdateAsync(TEntity entity);

        void DeleteAsync(TEntity entity);

        Task SaveChangesAsync();
    }
}

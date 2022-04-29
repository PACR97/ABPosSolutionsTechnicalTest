using ABPosSolutions.TechnicalTest.Application.Contracts.Persistence;
using ABPosSolutions.TechnicalTest.Domain.Common;
using ABPosSolutions.TechnicalTest.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ABPosSolutions.TechnicalTest.Infrastructure.Repos
{
    public class BaseRepo<TKey, TEntity> : IBaseRepo<TKey, TEntity> where TEntity : BaseDomainModel
    {
        protected readonly ApplicationDbContext context;

        public BaseRepo(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            await context.Set<TEntity>().AddAsync(entity);
            return entity;
        }

        public void DeleteAsync(TEntity entity)
        {
            context.Set<TEntity>().Remove(entity);
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            return await context.Set<TEntity>().ToListAsync();
        }

        public async Task<List<TEntity>> GetAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await context.Set<TEntity>().Where(predicate).ToListAsync();
        }

        public async Task<List<TEntity>> GetAsync(Expression<Func<TEntity, bool>>? predicate = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null, string? includeString = null, bool disableTracking = true)
        {
            IQueryable<TEntity> query = context.Set<TEntity>();
            if(disableTracking) query = query.AsNoTracking();
            if(!string.IsNullOrEmpty(includeString)) query = query.Include(includeString);
            if(predicate != null) query = query.Where(predicate);
            if(orderBy != null)
                return await orderBy(query).ToListAsync();
            return await query.ToListAsync();
        }

        public async Task<List<TEntity>> GetAsync(Expression<Func<TEntity, bool>>? predicate = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null, List<Expression<Func<TEntity, object>>>? includes = null, bool disableTracking = true)
        {
            IQueryable<TEntity> query = context.Set<TEntity>();
            if (disableTracking) query = query.AsNoTracking();
            if (includes != null) query = includes.Aggregate(query, (current, include) => current.Include(include));
            if(predicate != null) query = query.Where(predicate);
            if (orderBy != null)
                return await orderBy(query).ToListAsync();
            return await query.ToListAsync();
        }

        public async Task<TEntity?> GetByIdAsync(TKey id)
        {
            return await context.Set<TEntity>().FindAsync(id);
        }

        public async Task SaveChangesAsync()
        {
            await context.SaveChangesAsync();
        }

        public TEntity UpdateAsync(TEntity entity)
        {
            context.Set<TEntity>().Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
            return entity;
        }
    }
}

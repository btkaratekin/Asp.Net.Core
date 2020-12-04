using Microsoft.EntityFrameworkCore;
using OgrIsler.Core.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OgrIsler.Core.Concrete.EntityFrameWork
{
    public class EfRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
         where TContext : DbContext, new()
        where TEntity : class, IEntity, new()
    {
        public async void Delete(TEntity Entity)
        {
            using (var context = new TContext())
            {
                var DeleteEntity = context.Entry(Entity);
                DeleteEntity.State = EntityState.Deleted;
                await context.SaveChangesAsync();
            }
        }

        public async Task<TEntity> Get(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var context=new TContext())
            {
                return await context.Set<TEntity>().SingleOrDefaultAsync(filter);
            }
        }

        public async Task<IList<TEntity>> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var context = new TContext())
            {
                if (filter==null)
                {
                    return await context.Set<TEntity>().ToListAsync();
                }
                else
                {
                    return await context.Set<TEntity>().Where(filter).ToListAsync();
                }
            }
        }

        public async void Insert(TEntity Entity)
        {
            using (var context=new TContext())
            {
                var InsertEntity = context.Entry(Entity);
                InsertEntity.State = EntityState.Added;
                await context.SaveChangesAsync();
            }
        }

        public async void Update(TEntity Entity)
        {
            using (var context = new TContext())
            {
                var UpdateEntity = context.Entry(Entity);
                UpdateEntity.State = EntityState.Modified;
                await context.SaveChangesAsync();
            }
        }
    }
}

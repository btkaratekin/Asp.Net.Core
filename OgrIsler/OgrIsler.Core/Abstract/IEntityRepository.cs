using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace OgrIsler.Core.Abstract
{
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        Task<T> Get(Expression<Func<T, bool>> filter = null);
        Task<IList<T>> GetList(Expression<Func<T, bool>> filter = null);
        void Insert(T Entity);
        void Update(T Entity);
        void Delete(T Entity);


    }
}

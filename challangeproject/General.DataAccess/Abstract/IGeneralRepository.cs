using System;
using System.Collections.Generic;
using System.Linq.Expressions;


namespace General.DataAccess.Abstract
{
    public interface IGeneralRepository<T>
    {
        T GetById(int id);
        T GetByString(string filter);
        T GetDefault(Expression<Func<T, bool>> filter);
        IEnumerable<T> GetCustomAll(Expression<Func<T, bool>> filter = null);
        List<T> GetAll(Expression<Func<T, bool>> filter = null);

        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}

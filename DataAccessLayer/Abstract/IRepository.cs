using System.Linq.Expressions;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T>
    {
        List<T> List();
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);

        List<T> List(Expression<Func<T, bool>> filter);
    }
}

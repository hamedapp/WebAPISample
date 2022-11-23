using Domain.Interfaces.Entity;
using System.Linq.Expressions;

namespace Domain.Interfaces.Repository
{
    public interface IRepositoryBase<T> where T : IBaseEntity
    {
        T Add(T newEntity);

        void Delete(int Id);

        T Get(int Id);

        T Update(T newEntity);

        IEnumerable<T> GetAll();

        IEnumerable<T> GetAll(Expression<Func<T, bool>> predicate);
    }
}

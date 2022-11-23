using Domain.Interfaces.Entity;
using Domain.Interfaces.Repository;
using System.Linq.Expressions;

namespace Infrastructure.Repository
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class, IBaseEntity
    {

        public T Add(T newEntity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public T Get(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public T Update(T newEntity)
        {
            throw new NotImplementedException();
        }
    }
}

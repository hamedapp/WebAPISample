using Domain.Interfaces.Entity;
using Domain.Interfaces.Repository;
using Infrastructure.Contexs;
using System.Linq.Expressions;

namespace Infrastructure.Repository
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class, IBaseEntity
    {
        protected readonly CustomerContext customerContext;
        public RepositoryBase(CustomerContext context)
        {
            customerContext = context;
        }

        public virtual T Add(T newEntity)
        {
            newEntity.Created = DateTime.Now;

            var track = customerContext.Set<T>().Add(newEntity);
            customerContext.SaveChanges();

            return track.Entity;
        }

        public virtual void Delete(int Id)
        {
            var entity = customerContext.Set<T>().Where(x => x.Id == Id).FirstOrDefault();

            if (entity != null)
            {
                //maybe soft delete
                customerContext.Remove(entity);

            }
            customerContext.SaveChanges();
        }

        public virtual T Get(int Id)
        {
            throw new NotImplementedException();
        }

        public virtual IEnumerable<T> GetAll()
        {
            var list = customerContext.Set<T>();

            return list;
        }

        public virtual IEnumerable<T> GetAll(Expression<Func<T, bool>> predicate)
        {
            var list = customerContext.Set<T>().Where(predicate);

            return list;
        }

        public virtual T Update(T newEntity)
        {
            var tempEntity = customerContext.Set<T>().Find(newEntity.Id);

            if (tempEntity != null)
            {
                tempEntity.Modified = DateTime.Now;

                customerContext.Entry(tempEntity).CurrentValues.SetValues(newEntity);

                customerContext.SaveChanges();

                return customerContext.Entry(newEntity).Entity;
            }
            return tempEntity;
        }
    }
}

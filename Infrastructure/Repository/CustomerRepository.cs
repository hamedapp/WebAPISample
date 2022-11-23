using Domain.Dtos;
using Domain.Entities;
using Domain.Interfaces.Repository;
using Domain.Contexs;

namespace Domain.Repository
{
    public class CustomerRepository: RepositoryBase<Customer>, ICustomerRepository
    {
        public CustomerRepository(CustomerContext context): base(context)
        {
        }

    }
}

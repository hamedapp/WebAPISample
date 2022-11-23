using Domain.Dtos;
using Domain.Entities;
using Domain.Interfaces.Repository;
using Infrastructure.Contexs;

namespace Infrastructure.Repository
{
    public class CustomerRepository: RepositoryBase<Customer>, ICustomerRepository
    {
        public CustomerRepository(CustomerContext context): base(context)
        {

        }

    }
}

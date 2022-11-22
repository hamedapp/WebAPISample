using Domain.Dtos;
using Domain.Entities;

namespace Domain.Interfaces
{
    public interface ICustomerServcie : IBaseServices<Customer, CustomerDto>
    {
    }
}

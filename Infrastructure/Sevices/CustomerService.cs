using AutoMapper;
using Domain.Dtos;
using Domain.Entities;
using Domain.Interfaces.Repository;
using Domain.Interfaces.Service;

namespace Infrastructure.Sevices
{
    public class CustomerService : ServiceBase<Customer, CustomerDto>, ICustomerServcie
    {
        private readonly ICustomerRepository _repository;
        private readonly IMapper _mapper;
        public CustomerService(ICustomerRepository rpository, IMapper mapper) 
            : base(rpository, mapper)
        {
            _repository = rpository;
            _mapper = mapper;
        }

        public List<CustomerDto> GetAll()
        {
            var data = _repository.GetAll().ToList();
            var result = new List<CustomerDto>();
            if (data.Any())
            {
                 result = _mapper.Map<List<CustomerDto>>(data);

                return result;
            }
            return result;
        }

        public CustomerDto Get(int Id)
        {
            throw new NotImplementedException();
        }
     
    }
}

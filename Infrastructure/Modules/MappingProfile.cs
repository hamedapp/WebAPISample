using AutoMapper;
using Domain.Dtos;
using Domain.Entities;

namespace Infrastructure.Modules
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Customer, CustomerDto>().ReverseMap();
            //CreateMap<List<Customer>, List<CustomerDto>>().ReverseMap();
        }
    }
}

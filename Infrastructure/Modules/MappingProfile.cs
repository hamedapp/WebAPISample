using AutoMapper;
using Domain.Dtos;
using Domain.Entities;

namespace Domain.Modules
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Customer, CustomerDto>().ReverseMap();
        }
    }
}

﻿using AutoMapper;
using Domain.Dtos;
using Domain.Entities;
using Domain.Interfaces.Repository;
using Domain.Interfaces.Service;
using Microsoft.AspNetCore.Mvc;

namespace Application.Services
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
            var data = _repository.Get(Id);

            if (data is null)
            {
                throw new Exception("not found");
            }
            var result = _mapper.Map<CustomerDto>(data);
            return result;
        }

    }
}

using AutoMapper;
using Domain.Dtos;
using Domain.Entities;
using Domain.Interfaces.Repository;

namespace Infrastructure.Sevices
{
    public class ServiceBase<TEntity, TDto>
        where TEntity : BaseEntity
        where TDto : BaseDto
    {
        private readonly IRepositoryBase<TEntity> _repository;
        private readonly IMapper _mapper;

        public ServiceBase(IRepositoryBase<TEntity> rpository, IMapper mapper)
        {
            _repository = rpository;
            this._mapper = mapper;
        }

        public virtual void Update(TDto dto)
        {
            var entity = _mapper.Map<TEntity>(dto);

            _repository.Update(entity);
        }
        public void Delete(int Id)
        {
            _repository.Delete(Id);
        }
        public void Insert(CustomerDto dto)
        {
            var entity = _mapper.Map<TEntity>(dto);
            

            _repository.Add(entity);
        }
    }
}

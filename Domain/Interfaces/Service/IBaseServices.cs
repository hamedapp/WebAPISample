using Domain.Interfaces.Dto;

namespace Domain.Interfaces.Service
{
    public interface IBaseServices<TEntity, TDto> where TDto : IBaseDto
    {
        TDto GetAll();

        TDto Get(int Id);

        void Insert(TDto dto);

        void Update(TDto dto);

        void Delete(int Id);
    }
}

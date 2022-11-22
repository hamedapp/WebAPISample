namespace Domain.Interfaces
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

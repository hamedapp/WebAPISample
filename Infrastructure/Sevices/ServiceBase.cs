using Domain.Dtos;
using Domain.Entities;

namespace Infrastructure.Sevices
{
    public class ServiceBase<TEntity, TDto>
        where TEntity : BaseEntity
        where TDto : BaseDto
    {
    }
}

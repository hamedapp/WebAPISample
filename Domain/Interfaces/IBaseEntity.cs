namespace Domain.Interfaces
{
    public interface IBaseEntity
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Modified { get; set; }
    }
}

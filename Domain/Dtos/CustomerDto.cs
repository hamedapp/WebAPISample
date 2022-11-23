namespace Domain.Dtos
{
    public class CustomerDto : BaseDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
    }
}

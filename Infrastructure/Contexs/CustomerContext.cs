using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Domain.Contexs
{
    public class CustomerContext : DbContext
    {
        public CustomerContext(DbContextOptions<CustomerContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
    }
}

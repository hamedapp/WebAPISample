using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Contexs
{
    public class CustomerContext : DbContext
    {
        public CustomerContext(DbContextOptions<CustomerContext> options) : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
    }
}

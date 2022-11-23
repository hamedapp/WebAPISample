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

        //protected override void OnModelCreation(ModelBuilder modelBuilder) {
        //    modelBuilder.Entity<Customer>().ToTable(nameof(Customer), "Main");
        //}
    }
}

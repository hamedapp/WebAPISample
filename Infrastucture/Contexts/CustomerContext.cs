using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastucture.Contexts
{
    internal class CustomerContext : DbContext
    {
        public CustomerContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Customer> Categories { get; set; }
        protected override void OnConfiguring() { }
    }
}

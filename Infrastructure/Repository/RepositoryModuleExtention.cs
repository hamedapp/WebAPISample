using Domain.Interfaces.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Repository
{
    public static class RepositoryModuleExtention
    {
        public static void RegisterRepositoris(this IServiceCollection services)
        {
            services.AddTransient<ICustomerRepository, CustomerRepository>();
        }
    }
}

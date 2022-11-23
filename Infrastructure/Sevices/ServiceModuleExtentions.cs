using Domain.Interfaces.Service;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Sevices
{
    public static class ServiceModuleExtentions
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddTransient<ICustomerServcie, CustomerService>();
        }
    }
}

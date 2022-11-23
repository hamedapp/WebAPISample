using Domain.Interfaces.Service;
using Microsoft.Extensions.DependencyInjection;

namespace Domain.Sevices
{
    public static class ServiceModuleExtentions
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddTransient<ICustomerServcie, CustomerService>();
            //services.AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<CustomerDto>());

        }
    }
}

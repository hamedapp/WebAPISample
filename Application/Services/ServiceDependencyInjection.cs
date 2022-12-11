using Domain.Dtos;
using Domain.Interfaces.Service;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace Application.Services
{
    public static class ServiceDependencyInjection
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddTransient<ICustomerServcie, CustomerService>();
        }
    }
}

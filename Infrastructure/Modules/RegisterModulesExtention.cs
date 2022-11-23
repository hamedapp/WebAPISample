using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace Domain.Modules
{
    public static class RegisterModulesExtention
    {
        public static IServiceCollection RegisterModules(this IServiceCollection services)
        {
            var autoMapper = registerMapper();
            services.AddSingleton(autoMapper);

            return services;
        }

        public static IMapper registerMapper()
        {
            var mappingConfig = new MapperConfiguration(
                mc =>
                {
                    mc.AddProfile(new MappingProfile());
                }
                );
            var mapper = mappingConfig.CreateMapper();
            return mapper;
        }
    }
}

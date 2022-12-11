using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace Domain.Modules
{
    public static class RegisterModulesExtention
    {
        public static IServiceCollection RegisterMapperModules(this IServiceCollection services)
        {
            var autoMapper = RegisterMapper();
            services.AddSingleton(autoMapper);

            return services;
        }

        public static IMapper RegisterMapper()
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

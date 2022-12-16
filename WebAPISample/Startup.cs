using Domain.Contexs;
using Domain.Modules;
using Domain.Repository;
using Microsoft.EntityFrameworkCore;
using WebAPISample.Modules;
using Application.Services;
using FluentValidation.AspNetCore;

namespace WebAPISample
{
    public class Startup
    {
        public IConfiguration Config { get; }
        public Startup(IConfiguration configuration)
        {
            Config = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
 
            services.RegisterMapperModules();
            services.RegisterServices();
            services.RegisterRepositoris();
            
            services.AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<ValidationModule>());

            services.AddDbContext<CustomerContext>(opt =>
            {
                opt.UseInMemoryDatabase("CustomerDb");
            });

            services.AddCors();
        }

        public void Configure(WebApplication app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseCors(
                options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()
            );
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            app.MapControllers();

            app.Run();
        }
    }
}

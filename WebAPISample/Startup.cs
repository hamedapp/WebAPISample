using Domain.Dtos;
using FluentValidation;
using Domain.Contexs;
using Domain.Modules;
using Domain.Repository;
using Domain.Sevices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPISample.Modules;
using FluentValidation.AspNetCore;
using System.Reflection;

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
            // .AddFluentValidation(options =>
            //{
            //    // Validate child properties and root collection elements
            //    options.ImplicitlyValidateChildProperties = true;
            //    options.ImplicitlyValidateRootCollectionElements = true;

            //    // Automatic registration of validators in assembly
            //    options.RegisterValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            //}); 
            services.RegisterModules();
            services.RegisterServices();
            services.RegisterRepositoris();

            services.AddMvc();

            services.Configure<ApiBehaviorOptions>(options =>
            {
                options.SuppressModelStateInvalidFilter = true;
            });
            services.AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<ValidationModule>());
            services.AddScoped<IValidator<CustomerDto>, ValidationModule>();

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

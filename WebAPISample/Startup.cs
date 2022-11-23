using System;
using Infrastructure.Contexs;
using Infrastructure.Modules;
using Infrastructure.Repository;
using Infrastructure.Sevices;
using Microsoft.EntityFrameworkCore;

namespace WebAPISample
{
    public class Startup
    {
        public IConfiguration _config { get; }
        public Startup(IConfiguration configuration)
        {
            _config = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.RegisterModules();
            services.RegisterServices();
            services.RegisterRepositoris();
            services.AddDbContext<CustomerContext>(opt =>
            {
                opt.UseInMemoryDatabase("CustomerDb");
            });
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
            //app.UseHealthChecks("/health");

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            app.MapControllers();

            app.Run();
        }



    }
}

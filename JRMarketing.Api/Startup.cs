using AutoMapper;
using FluentValidation.AspNetCore;
using JRMarketing.Application.Services;
using JRMarketing.Domain.Interfaces;
using JRMarketing.Infrastructure.Data;
using JRMarketing.Infrastructure.Filters;
using JRMarketing.Infrastructure.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace JRMarketing.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());           
            services.AddControllers(options => options.Filters.Add<GlobalExceptionFilter>());
            services.AddDbContext<JRMarketingContext>(options => options.UseSqlServer(Configuration.GetConnectionString("JRMarketingEF")));
            services.AddScoped(typeof(IRepository<>), typeof(SQLRepository<>));
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IUsuarioServices, UsuarioService>();
            services.AddTransient<IEtiquetumService, EtiquetumService>();
            services.AddMvc().AddFluentValidation(options => options.RegisterValidatorsFromAssemblies(AppDomain.CurrentDomain.GetAssemblies()));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

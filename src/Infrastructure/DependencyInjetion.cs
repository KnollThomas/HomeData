using Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace Infrastructure
{
    public static class DependencyInjetion
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, Microsoft.Extensions.Configuration.IConfiguration configuration)
        {
            services.AddDbContext<TemperatureDb>(options =>
                                             options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                                             b => b.MigrationsAssembly(typeof(TemperatureDb).Assembly.FullName)));



            services.AddScoped<Application.Interfaces.IApplicationDbContext>(provider => provider.GetService<Infrastructure.Database.TemperatureDb>());

            return services;
        }

    }
}

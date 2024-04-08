using ECommerceApp.Application.Interfaces.Repository;
using ECommerceApp.Domain.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistance.Context;
using Persistance.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Persistance
{
    public static class ServiceRegistration
    {
        public static void AddPersistanceRegistration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ECommerceDbContext>(options =>
                           options.UseSqlServer(configuration.GetConnectionString("ConnectionStrings"),
                                          b => b.MigrationsAssembly(typeof(ECommerceDbContext).Assembly.FullName)));

            //services.AddScoped<IProductRepository, ProductRepository>();
            //services.AddScoped<IProductCategoryRepository, ProductCategoryRepository>();

            var assm = Assembly.GetExecutingAssembly();
            var repositoryTypes = assm.GetTypes().Where(x => x.IsClass && !x.IsAbstract && x.GetInterfaces().Any(i => i.Name == $"I{x.Name}"));

            foreach (var type in repositoryTypes)
            {
                var interfaceType = type.GetInterface($"I{type.Name}");
                if (interfaceType != null)
                {
                    services.AddScoped(interfaceType, type);
                }
            }
        }
    }
}

﻿using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApp.Application
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddApplicationRegistration(this IServiceCollection services)
        {
            var assm = Assembly.GetExecutingAssembly();

            services.AddAutoMapper(assm);
            services.AddMediatR(assm);
            return services;
        }
    }
}

using Aplicatie_SmartCity.Seeders;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplicatie_SmartCity
{
    public static class ServiceExtensions
    {
        public static void AddSeeders(this IServiceCollection services)
        {
            services.AddTransient<InitialSeeder>();
        }
    }
}

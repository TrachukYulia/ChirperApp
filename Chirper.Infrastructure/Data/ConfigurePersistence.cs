using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using Chirper.Application.Repositories;
using Chirper.Infrastructure.Repositories;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chirper.Infrastructure.Data
{
    public static class ServiceExtensions
    {
        public static void ConfigurePersistence(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContext<ChirperContext>(options =>
               options.UseNpgsql(
               configuration.GetConnectionString("DefaultConnection"))
               );
        }
    }
}

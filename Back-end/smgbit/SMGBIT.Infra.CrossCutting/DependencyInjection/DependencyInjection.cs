using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using SMGBIT.Infra.Data.Context;
using SMGBIT.Infra.Data.Repository;
using SMGBIT.Core.Interfaces;
using SMGBIT.Application.Interfaces;
using SMGBIT.Application.Services;
using SMGBIT.Application.Mappings;

namespace  SMGBIT.Infra.CrossCutting
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services,
            IConfiguration configuration
            )
        {
            services.AddDbContext<ApplicationContext>(options=>
              options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"
            ), b => b.MigrationsAssembly(typeof(ApplicationContext).Assembly.FullName)));

         
            services.AddScoped<ITabelaFreteRepository, TabelaFreteRepository>();
            services.AddScoped<IViagensRepository, ViagensRepository>();

            services.AddScoped<ITabelaFreteService, TabelaFreteService>();
            services.AddScoped<IViagensService, ViagensService>();            
            services.AddAutoMapper(typeof(DTOMapping));

            return services;
        }
    }
}

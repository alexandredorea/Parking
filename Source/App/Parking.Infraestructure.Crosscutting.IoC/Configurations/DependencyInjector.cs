using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Parking.Domain.Interfaces.Repositories;
using Parking.Domain.Interfaces.UoW;
using Parking.Infraestructure.Data.Context.Base;
using Parking.Infraestructure.Data.Repository;
using Parking.Infraestructure.Data.UoW;

namespace Parking.Infraestructure.Crosscutting.IoC.Configurations
{
    public class DependencyInjector
    {
        public static void Inject(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<BaseContext>(options => options.UseSqlServer(configuration.GetConnectionString("SQLServerConnection")));

            //IoD: Repositories
            services.AddScoped<IParkingRepository, ParkingRepository>();
            services.AddScoped<ITariffRepository, TariffRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<BaseContext>();
        }
    }
}

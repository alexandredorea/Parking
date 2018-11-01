using Microsoft.EntityFrameworkCore;
using Parking.Infraestructure.Data.Mapping;

namespace Parking.Infraestructure.Data.Context.Base
{
    public class BaseContext : DbContext
    {
        public BaseContext(DbContextOptions options) : base(options)
        {
            // Garante com que o banco seja criado a partir das classes 
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ParkingMapping());
            modelBuilder.ApplyConfiguration(new TariffMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}

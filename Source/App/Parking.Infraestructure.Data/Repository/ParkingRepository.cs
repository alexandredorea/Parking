using Parking.Domain.Interfaces.Repositories;
using Parking.Infraestructure.Data.Context.Base;
using Parking.Infraestructure.Data.Repository.Base;

namespace Parking.Infraestructure.Data.Repository
{
    public class ParkingRepository : RepositoryBase<Domain.Entities.Parking, string>, IParkingRepository
    {
        public ParkingRepository(BaseContext context) : base(context)
        {
        }
    }
}
using Parking.Domain.Interfaces.Repositories.Base;

namespace Parking.Domain.Interfaces.Repositories
{
    public interface IParkingRepository : IRepositoryBase<Domain.Entities.Parking, string>
    {
    }
}

using Parking.Domain.Entities;
using Parking.Domain.Interfaces.Repositories.Base;
using System;

namespace Parking.Domain.Interfaces.Repositories
{
    public interface ITariffRepository : IRepositoryBase<Tariff, int>
    {
        decimal GetValueHour(DateTime checkIn);
    }
}

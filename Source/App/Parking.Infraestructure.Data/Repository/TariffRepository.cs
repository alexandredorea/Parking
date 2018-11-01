using Parking.Domain.Entities;
using Parking.Domain.Interfaces.Repositories;
using Parking.Infraestructure.Data.Context.Base;
using Parking.Infraestructure.Data.Repository.Base;
using System;
using System.Linq;

namespace Parking.Infraestructure.Data.Repository
{
    public class TariffRepository : RepositoryBase<Tariff, int>, ITariffRepository
    {
        public TariffRepository(BaseContext context) : base(context)
        {
        }

        public decimal GetValueHour(DateTime checkIn)
        {
            return Set.Where(x => x.StartEffectiveDate >= checkIn && x.LastEffectiveDate <= checkIn)
                      .Select(x => x.ValueHour)
                      .FirstOrDefault();
        }
    }
}

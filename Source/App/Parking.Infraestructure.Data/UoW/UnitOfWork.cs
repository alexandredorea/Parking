using Parking.Domain.Interfaces.UoW;
using Parking.Infraestructure.Data.Context.Base;

namespace Parking.Infraestructure.Data.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BaseContext _context;

        public UnitOfWork(BaseContext context)
        {
            _context = context;
        }

        public bool Commit()
        {
            return _context.SaveChanges() > 0;
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}

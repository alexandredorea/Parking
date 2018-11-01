using Flunt.Notifications;
using Parking.Domain.Interfaces.Entities.Base;

namespace Parking.Domain.Entities.Base
{
    public abstract class EntityBase<TKey> : Notifiable, IEntityBase<TKey>
    {
        public TKey Id { get; private set; }

        public void SetId(TKey id)
        {
            Id = id;
        }
    }
}

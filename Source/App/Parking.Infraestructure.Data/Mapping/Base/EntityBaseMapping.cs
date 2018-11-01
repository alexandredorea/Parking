using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Parking.Domain.Entities.Base;

namespace Parking.Infraestructure.Data.Mapping.Base
{
    public class EntityBaseMapping<EntityType, TKey> : IEntityTypeConfiguration<EntityType> where EntityType : EntityBase<TKey>
    {
        public virtual void Configure(EntityTypeBuilder<EntityType> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Parking.Domain.Entities.Base;
using Parking.Domain.Interfaces.Repositories.Base;
using Parking.Infraestructure.Data.Context.Base;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Parking.Infraestructure.Data.Repository.Base
{
    public class RepositoryBase<EntityType, TKey> : IRepositoryBase<EntityType, TKey> where EntityType : EntityBase<TKey>
    {
        protected readonly BaseContext Context;
        protected readonly DbSet<EntityType> Set;

        public RepositoryBase(BaseContext context)
        {
            Context = context;
            Set = Context.Set<EntityType>();
        }

        public void Add(EntityType entityObject)
        {
            Set.Add(entityObject);
        }

        public IEnumerable<EntityType> Get()
        {
            return Set.ToList();
        }

        public EntityType Get(TKey id)
        {
            return Set.Find(id);
        }

        public void Remove(EntityType entityObject)
        {
            Set.Remove(entityObject);
        }

        public void Remove(TKey id)
        {
            Set.Remove(this.Get(id));
        }

        public int SaveChanges()
        {
            return Context.SaveChanges();
        }

        public void Update(EntityType entityObject)
        {
            Set.Update(entityObject);
        }

        public void Dispose()
        {
            Context.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}

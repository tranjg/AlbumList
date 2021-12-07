using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace AlbumList.Models
{

    public class Repository<S> : IRepository<S> where S : class
    {
        protected AlbumContext context { get; set; }

        private DbSet<S> dbSet { get; set; }

        public Repository(AlbumContext ctx)
        {
            context = ctx;
            dbSet = context.Set<S>();
        }

        public virtual IEnumerable<S> List()
        {
            IQueryable<S> query = dbSet;

            return query.ToList();
        }

        public virtual S Get(int id) => dbSet.Find(id);

        public virtual void Insert(S entity) => dbSet.Add(entity);
        public virtual void Update(S entity) => dbSet.Update(entity);
        public virtual void Delete(S entity) => dbSet.Remove(entity);
        public virtual void Save() => context.SaveChanges();

    }
}

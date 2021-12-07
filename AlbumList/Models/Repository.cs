using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

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
        // public virtual void Save() => context.SaveChanges();

        public virtual void Save()
        {
            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Debug.WriteLine(@"Entity of type ""{0}"" in state ""{1}"" 
                   has the following validation errors:",
                        eve.Entry.Entity.GetType().Name,
                        eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Debug.WriteLine(@"- Property: ""{0}"", Error: ""{1}""",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
            catch (DbUpdateException e)
            {
                //Add your code to inspect the inner exception and/or
                //e.Entries here.
                //Or just use the debugger.
                //Added this catch (after the comments below) to make it more obvious 
                //how this code might help this specific problem
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }

        }
    }
}

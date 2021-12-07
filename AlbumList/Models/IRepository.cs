using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumList.Models
{
    public interface IRepository<S> where S : class
    {
        IEnumerable<S> List();

        S Get(int id);

        void Insert(S entity);

        void Update(S entity);

        void Delete(S entity);

        void Save();
    }
}

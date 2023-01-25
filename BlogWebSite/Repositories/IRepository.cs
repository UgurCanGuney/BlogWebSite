using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IRepository<T>
    {
        List<T> Listele();
        void Add(T entity);
        bool Delete(T entity);
        bool Update(T entity);

    }
}

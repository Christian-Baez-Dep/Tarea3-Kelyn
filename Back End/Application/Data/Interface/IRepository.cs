using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Interface
{
    public interface IRepository<T>
    {
        public T Get(int id);
        public bool Update(T entity);
        public bool Delete(int id);
        public List<T> GetAll();   
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T> where T: class, new()
    {
        List<T> GetAllEntityItems();
        T GetEntityById(int id);
        void InsertEntity(T entity);
        void DeleteEntity(T entity);
        void UpdateEntity(T entity);
    }
}

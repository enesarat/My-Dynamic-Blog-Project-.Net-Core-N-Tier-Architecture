using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T> where T: class, new()
    {
        List<T> GetAllEntityItems();
        List<T> GetListAllByFilter(Expression<Func<T, bool>> filter);
        T GetEntityById(int id);
        void InsertEntity(T entity);
        void DeleteEntity(T entity);
        void UpdateEntity(T entity);
    }
}

using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericEntityDAL<T> where T:class,IEntity,new()
    {
        List<T> GetAllItems();
        List<T> GetAllItemsByFilter(Expression<Func<T, bool>> filter);
        T GetById(int id);
        void Insert(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}

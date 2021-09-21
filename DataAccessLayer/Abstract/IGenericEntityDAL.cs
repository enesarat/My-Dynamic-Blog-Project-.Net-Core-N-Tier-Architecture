using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericEntityDAL<T> where T:class,IEntity,new()
    {
        List<T> GetAllItems();
        T GetById(int id);
        void Insert(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}

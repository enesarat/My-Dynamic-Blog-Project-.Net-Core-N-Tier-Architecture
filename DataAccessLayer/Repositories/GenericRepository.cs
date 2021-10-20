using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericEntityDAL<T> where T : class, IEntity, new()
    {
        public void Delete(T entity)
        {
            using (Context dbContext = new Context())
            {
                dbContext.Set<T>().Remove(entity);
                dbContext.SaveChanges();
            }
        }

        public List<T> GetAllItems()
        {
            using (Context dbContext = new Context())
            {
                var entityList = dbContext.Set<T>().ToList();
                return entityList;
            }
        }

        public List<T> GetAllItemsByFilter(Expression<Func<T, bool>> filter)
        {
            using (Context dbContext = new Context())
            {
                if (filter == null)
                {
                    var entityList = dbContext.Set<T>().ToList();
                    return entityList;
                }
                else
                {
                    var entityList = dbContext.Set<T>().Where(filter).ToList();
                    return entityList;
                }
            }
        }

        public T GetById(int id)
        {
            using (Context dbContext = new Context())
            {
                var entity = dbContext.Set<T>().Find(id);
                return entity;
            }
        }

        public void Insert(T entity)
        {
            using (Context dbContext = new Context())
            {
                dbContext.Set<T>().Add(entity);
                dbContext.SaveChanges();
            }
        }

        public void Update(T entity)
        {
            using (Context dbContext = new Context())
            {
                dbContext.Set<T>().Update(entity);
                dbContext.SaveChanges();
            }
        }
    }
}

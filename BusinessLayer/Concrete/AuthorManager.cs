using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AuthorManager : IAuthorService
    {
        IAuthorDAL authorAccess;

        public AuthorManager(IAuthorDAL accessLevelType)
        {
            authorAccess = accessLevelType;
        }

        public void DeleteEntity(Author entity)
        {
            authorAccess.Delete(entity);
        }

        public List<Author> GetAllEntityItems()
        {
            return authorAccess.GetAllItems();
        }

        public Author GetEntityById(int id)
        {
            return authorAccess.GetById(id);
        }

        public List<Author> GetListAllByFilter(Expression<Func<Author, bool>> filter)
        {
            return authorAccess.GetAllItemsByFilter(filter);
        }

        public void InsertEntity(Author entity)
        {
            authorAccess.Insert(entity);
        }

        public void UpdateEntity(Author entity)
        {
            authorAccess.Update(entity);
        }
    }
}

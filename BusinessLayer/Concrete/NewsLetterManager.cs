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
    public class NewsLetterManager : INewsLetterService
    {
        INewsLetterDAL newsLetterAccess;
        public NewsLetterManager(INewsLetterDAL AccessLevelType)
        {
            newsLetterAccess = AccessLevelType;
        }
        public void DeleteEntity(NewsLetter entity)
        {
            newsLetterAccess.Delete(entity);
        }

        public List<NewsLetter> GetAllEntityItems()
        {
            return newsLetterAccess.GetAllItems();
        }

        public NewsLetter GetEntityById(int id)
        {
            return newsLetterAccess.GetById(id);
        }

        public List<NewsLetter> GetListAllByFilter(Expression<Func<NewsLetter, bool>> filter)
        {
            return newsLetterAccess.GetAllItemsByFilter(filter);
        }

        public void InsertEntity(NewsLetter entity)
        {
            newsLetterAccess.Insert(entity);
        }

        public void UpdateEntity(NewsLetter entity)
        {
            newsLetterAccess.Update(entity);
        }
    }
}

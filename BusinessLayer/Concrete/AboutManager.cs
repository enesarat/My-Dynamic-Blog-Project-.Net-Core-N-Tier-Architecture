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
    public class AboutManager : IAboutService
    {
        IAboutDAL aboutAccess;

        public AboutManager(IAboutDAL accessLevelType)
        {
            aboutAccess = accessLevelType;
        }

        public void DeleteEntity(About entity)
        {
            aboutAccess.Delete(entity);
        }

        public List<About> GetAllEntityItems()
        {
            return aboutAccess.GetAllItems();
        }

        public About GetEntityById(int id)
        {
            return aboutAccess.GetById(id);
        }

        public List<About> GetListAllByFilter(Expression<Func<About, bool>> filter)
        {
            return aboutAccess.GetAllItemsByFilter(filter);
        }

        public void InsertEntity(About entity)
        {
            aboutAccess.Insert(entity);
        }

        public void UpdateEntity(About entity)
        {
            aboutAccess.Update(entity);
        }
    }
}

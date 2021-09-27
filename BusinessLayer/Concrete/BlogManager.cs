using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BlogManager : IBlogService
    {
        IBlogDAL blogAccess;

        public BlogManager(IBlogDAL accessLevelType)
        {
            blogAccess = accessLevelType;
        }
        public void DeleteEntity(Blog entity)
        {
            blogAccess.Delete(entity);
        }

        public List<Blog> GetAllEntityItems()
        {
            return blogAccess.GetAllItems();
        }

        public Blog GetEntityById(int id)
        {
            return blogAccess.GetById(id);
        }

        public void InsertEntity(Blog entity)
        {
            blogAccess.Insert(entity);
        }

        public void UpdateEntity(Blog entity)
        {
            blogAccess.Update(entity);
        }
    }
}

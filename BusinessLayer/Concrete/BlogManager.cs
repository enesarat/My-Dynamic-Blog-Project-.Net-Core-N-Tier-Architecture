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

        public List<Blog> GetBlogListWithCategory()
        {
            return blogAccess.GetListWithCategories();
        }

        public Blog GetEntityById(int id)
        {
            return blogAccess.GetById(id);
        }

        public List<Blog> GetListAllByFilter(Expression<Func<Blog, bool>> filter)
        {
            return blogAccess.GetAllItemsByFilter(filter);
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
